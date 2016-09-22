using System;
using System.Linq;
using CoreTechs.Common.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Ionic.Zip;
using HtmlAgilityPack;
using System.Net;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace WcaApiWebJob
{
    class Program
    {
        private static string _connectionstring;
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("config.json").AddEnvironmentVariables();

            var config = builder.Build();
            _connectionstring = config["Data:WcaDbApiContext:ConnectionString"];


      string downloadedFile = string.Empty;
            //var zipFile = DownloadFile(out downloadedFile, @"C:\Programmering\WCATab\WCATab\bin\Debug\Zip\WCA_export017_20150612.tsv.zip");           
            var zipFile = DownloadFile(out downloadedFile);
            if (zipFile == null)
            {
                Console.WriteLine("No new files was found. Latest file is " + GetLatestImportedFile());
            }
            else
            {
                DateTime start;
                TimeSpan time;
                foreach (var table in Utils.tables.OrderBy(t => t.Order))
                {
                    Console.WriteLine(table.TableName + ": Start processing");
                    start = DateTime.Now;
                    ProcessTable(table.TableName, zipFile);
                    time = DateTime.Now - start;
                    Console.WriteLine(table.TableName + ": Done processing in "+time.Minutes+" minutes and "+time.Seconds + " secounds");
                }
                Console.WriteLine("Start merging data");
                foreach (var table in Utils.tables.OrderBy(t => t.Order))
                {
                    Console.WriteLine(table.TableName + ": Merge starded");
                    start = DateTime.Now;
                    MergeTable(table.TableName);
                    time = DateTime.Now - start;
                    Console.WriteLine(table.TableName + ": Done merging  in " + time.Minutes + " minutes and " + time.Seconds + " secounds");
                }
                SetImportedFile(downloadedFile);
            }
        }

        private static ZipFile DownloadFile(out string downloadedFile, string url = "")
        {
            downloadedFile = string.Empty;
            string latestFile = GetLatestImportedFile();
            MemoryStream ms = null;
            string link = "";
            try
            {
                if (url == string.Empty)
                {
                    HtmlDocument wcaSite = new HtmlDocument();
                    wcaSite.LoadHtml(new WebClient().DownloadString("https://www.worldcubeassociation.org/results/misc/export.html"));
                    link = wcaSite.DocumentNode.SelectNodes("//a[@href]").FirstOrDefault(t => t.Attributes["href"].Value.EndsWith("tsv.zip")).Attributes["href"].Value;
                    downloadedFile = link;
                    url = @"https://www.worldcubeassociation.org/results/misc/" + link;
                }
                if (link == latestFile && latestFile != string.Empty)
                    return null;
                WebClient wc = new WebClient();
                var bZip = wc.DownloadData(url);
                ms = new MemoryStream(bZip);
            }
            catch(Exception ex)
            {
                Console.Write("ERRER: Download faild: {0}\n{1}",url, ex.Message);
                return null;
            }
            
            return ZipFile.Read(ms);
        }

        private static void ProcessTable(string tableName, ZipFile zipFile)
        {
            var entry = zipFile[string.Format(@"WCA_export_{0}.tsv", tableName)];
            string tableNameDiff = tableName + Utils.WRITETABLESUFIX;
            var memoStream = new MemoryStream();
            entry.Extract(memoStream);
            memoStream.Position = 0;
            TextReader reader = new StreamReader(memoStream);
            var it = reader.ReadCsvWithHeader(delimiter: '\t').GetEnumerator();
            if (!it.MoveNext()) return;

            DataTable table = GetSchema(tableNameDiff);
            try
            {
                do
                {
                    var row = table.NewRow();
                    foreach (var k in it.Current.Keys)
                        row[k] = it.Current[k];

                    table.Rows.Add(row);

                } while (it.MoveNext());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine(tableName +": Truncating");
            Truncate(tableNameDiff);
            Console.WriteLine(tableName +": Done truncating");
            Insert(table, tableNameDiff);
        }

        private static void MergeTable(string tableName)
        {
            DataTable schema = GetSchema(tableName);
            List<string> columns = new List<string>();
            List<string> keys = new List<string>();
            foreach (UniqueConstraint unicqueConstrain in schema.Constraints)
            {
                if(unicqueConstrain.IsPrimaryKey)
                {
                    foreach (var column in unicqueConstrain.Columns)
                    {
                        keys.Add(column.ColumnName);
                    }
                }
            }
            foreach (DataColumn column in schema.Columns)
            {
                if(!keys.Contains(column.ColumnName))
                    columns.Add(column.ColumnName);
            }
            string mergeScript = CreateMergeScript(tableName, keys, columns);
            RunMergeScript(mergeScript);
        }

        private static string CreateMergeScript(string tableName, List<string> keys, List<string> columns)
        {
            var allColumns = new List<string>();
            allColumns.AddRange(keys);
            allColumns.AddRange(columns);
            var mergeScript = string.Format(@"
                BEGIN TRAN;
                MERGE {0} AS T USING {1} AS S ON({2})
                WHEN NOT MATCHED BY TARGET
                    THEN INSERT({3}) VALUES({4})
                WHEN MATCHED and({5})
                    THEN UPDATE SET {6}
                WHEN NOT MATCHED BY SOURCE
                    THEN DELETE;
                COMMIT TRAN;",tableName, tableName + Utils.WRITETABLESUFIX, Utils.CompKeys(keys), string.Join(",", allColumns), Utils.JoinInsertPrefix(allColumns, ", ", "S."), Utils.JoinMatchedAnd(columns), Utils.JoinMatchedAndUpdate(columns));

            return mergeScript;
        }

        private static void RunMergeScript(string script)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(script, conn);
                    cmd.CommandTimeout = 360;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private static string GetLatestImportedFile()
        {
            string wcaFilename = string.Empty;
            try
            {
                DataTable res = new DataTable();
                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    
                    string script = string.Format("select top(1) * from ImportedFiles order by imported desc");

                    SqlDataAdapter da = new SqlDataAdapter(script, conn);
                    da.Fill(res);
                    conn.Close();
                }

                if(res.Rows.Count == 1)
                {
                    wcaFilename = res.Rows[0]["wcaFileName"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return wcaFilename;
        }

        private static void SetImportedFile(string filename)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    string script = string.Format("insert into ImportedFiles (imported, wcaFileName) values(@date, @filename)");

                    SqlCommand cmd = new SqlCommand(script, conn);
                    cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now));
                    cmd.Parameters.Add(new SqlParameter("@filename", filename));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private static void Truncate(string tableName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("truncate table " + tableName, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private static void Delete(string tableName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("delete from " + tableName, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private static DataTable GetSchema(string tableName)
        {
            DataTable res = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from " + tableName + " where 1 <> 1", conn);
                    da.FillSchema(res, SchemaType.Mapped);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return res;
        }
        private static void Insert(DataTable table, string tableName)
        {
            Console.WriteLine(tableName + ": "+ table.Rows.Count + " rows to insert");
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    SqlBulkCopy bulkCopy = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, null);
                    bulkCopy.DestinationTableName = tableName;
                    bulkCopy.BulkCopyTimeout = 12 * 60;
                    bulkCopy.BatchSize = 1000;
                    bulkCopy.NotifyAfter = 100000;
                    bulkCopy.SqlRowsCopied += BulkCopy_SqlRowsCopied;
                    conn.Open();
                    bulkCopy.WriteToServer(table);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void BulkCopy_SqlRowsCopied(object sender, SqlRowsCopiedEventArgs e)
        {
            Console.WriteLine(e.RowsCopied + " rows insterted");
        }

        private static void CreatFKSQL()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(SQL.CreateFKSQL, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception)
            {


            }
        }

        private static void DropFKSQL()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(SQL.DropFKSQL, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception)
            {


            }
        }
    }
}

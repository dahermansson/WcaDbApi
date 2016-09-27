using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcaApiWebJob
{
    public static class Utils
    {
        public const string WRITETABLESUFIX = "_diff";

        //public static string[] tables = { "Persons", "Competitions", "Events", "Results", "RanksSingle", "RanksAverage", "Rounds", "Formats", "Countries", "Continents", "Scrambles" };

        public static Table[] tables = {
            new Table { Order = 1, TableName = "Continents", DeleteBeforeMerge = false },
            new Table { Order = 2, TableName = "Countries", DeleteBeforeMerge = false },
            new Table { Order = 3, TableName = "Formats", DeleteBeforeMerge = false  },
            new Table { Order = 4, TableName = "Events", DeleteBeforeMerge = false  },
            new Table { Order = 5, TableName = "Rounds", DeleteBeforeMerge = false  },
            new Table { Order = 6, TableName = "Persons", DeleteBeforeMerge = false  },
            new Table { Order = 7, TableName = "Competitions", DeleteBeforeMerge = false  },
            new Table { Order = 8, TableName = "Results", DeleteBeforeMerge = false  },
            new Table { Order = 9, TableName = "RanksSingle", DeleteBeforeMerge = false  },
            new Table { Order = 10, TableName = "RanksAverage", DeleteBeforeMerge = false  },
            new Table { Order = 11, TableName = "Scrambles", DeleteBeforeMerge = false  }

        };

        public static string JoinInsertPrefix(List<string> strings, string separator, string prefix)
        {
            string sep = separator + prefix;
            return prefix + string.Join(sep, strings);
        }

        public static string JoinMatchedAnd(List<string> columns)
        {
            StringBuilder sb = new StringBuilder();
            //t.name not like s.name or t.recordName <> s.recordName or t.latitude <> s.latitude or t.longitude <> s.longitude or t.zoom <> s.zoom
            var diffColumns = columns.Where(c => c != "id");
            for (int i = 0; i < diffColumns.Count(); i++)
            {
                if(i == diffColumns.Count() - 1)
                    sb.AppendFormat("T.{0} not like S.{0}", diffColumns.ElementAt(i));
                else
                    sb.AppendFormat("T.{0} not like S.{0} or ", diffColumns.ElementAt(i));
            }
            return sb.ToString();
        }

        public static string JoinMatchedAndUpdate(List<string> columns)
        {
            StringBuilder sb = new StringBuilder();
            //t.name = s.name, t.recordName = s.recordName, t.latitude = s.latitude, t.longitude = s.longitude, t.zoom = s.zoom
            var diffColumns = columns.Where(c => c != "id");
            for (int i = 0; i < diffColumns.Count(); i++)
            {
                if (i == diffColumns.Count() - 1)
                    sb.AppendFormat("T.{0} = S.{0}", diffColumns.ElementAt(i));
                else
                    sb.AppendFormat("T.{0} = S.{0}, ", diffColumns.ElementAt(i));
            }
            return sb.ToString();
        }

        internal static string CompKeys(List<string> keys)
        {
            StringBuilder sb = new StringBuilder();
            //T.id = S.id and T.subid = S.subid
            for (int i = 0; i < keys.Count(); i++)
            {
                if (i == keys.Count() - 1)
                    sb.AppendFormat("T.{0} = S.{0}", keys.ElementAt(i));
                else
                    sb.AppendFormat("T.{0} = S.{0} and ", keys.ElementAt(i));
            }
            return sb.ToString();
        }
    }


    

}

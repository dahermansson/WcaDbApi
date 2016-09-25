using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.ApiModels
{
    public class Format
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Sort_by { get; set; }
        public string Sort_by_second { get; set; }
        public string Expected_solve_count { get; set; }
        public int Trim_fastest_n { get; set; }
        public int Trim_slowest_n { get; set; }

        public static Format Map(Formats formats)
        {
            if (formats == null)
                return new Format();
            return new Format()
            {
                Id = formats.Id,
                Name = formats.Name,
                Expected_solve_count = formats.Expected_solve_count,
                Sort_by = formats.Sort_by,
                Sort_by_second = formats.Sort_by_second,
                Trim_fastest_n = formats.Trim_fastest_n,
                Trim_slowest_n = formats.Trim_slowest_n
            };
        }
    }
}

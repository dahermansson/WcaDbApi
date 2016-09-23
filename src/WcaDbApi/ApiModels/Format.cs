using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}

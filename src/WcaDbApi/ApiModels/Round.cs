using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WcaDbApi.ApiModels
{
    public class Round
    {
        public string Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public string CellName { get; set; }
        public int Final { get; set; }
    }
}

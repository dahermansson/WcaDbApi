using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class RoundsDiff
    {
        public string Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public string CellName { get; set; }
    }
}

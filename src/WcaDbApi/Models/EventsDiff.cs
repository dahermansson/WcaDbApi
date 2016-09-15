using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class EventsDiff
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public string Format { get; set; }
        public string CellName { get; set; }
    }
}

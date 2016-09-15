using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class RanksAverageDiff
    {
        public string PersonId { get; set; }
        public string EventId { get; set; }
        public int Best { get; set; }
        public int WorldRank { get; set; }
        public int ContinentRank { get; set; }
        public int CountryRank { get; set; }
    }
}

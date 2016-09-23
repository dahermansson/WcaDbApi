using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WcaDbApi.ApiModels
{
    public class RankSingle
    {
        public string PersonId { get; set; }
        public string EventId { get; set; }
        public int Best { get; set; }
        public int WorldRank { get; set; }
        public int ContinentRank { get; set; }
        public int CountryRank { get; set; }
    }
}

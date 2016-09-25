using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.ApiModels
{
    public class RankAverage
    {
        public string PersonId { get; set; }
        public string EventId { get; set; }
        public int Best { get; set; }
        public int WorldRank { get; set; }
        public int ContinentRank { get; set; }
        public int CountryRank { get; set; }

        internal static RankAverage Map(RanksAverage ranksAverage)
        {
            if (ranksAverage == null)
                return new RankAverage();
            return new RankAverage()
            {
                Best = ranksAverage.Best,
                ContinentRank = ranksAverage.ContinentRank,
                CountryRank = ranksAverage.CountryRank,
                WorldRank = ranksAverage.WorldRank,
                EventId = ranksAverage.EventId,
                PersonId = ranksAverage.PersonId
            };
        }
    }
}

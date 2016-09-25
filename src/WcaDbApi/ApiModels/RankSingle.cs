using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

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

        internal static RankSingle Map(RanksSingle ranksSingles)
        {
            if(ranksSingles == null)
                return new RankSingle();
            return new RankSingle()
            {
                Best = ranksSingles.Best,
                ContinentRank = ranksSingles.ContinentRank,
                CountryRank = ranksSingles.CountryRank,
                WorldRank = ranksSingles.WorldRank,
                EventId = ranksSingles.EventId,
                PersonId = ranksSingles.PersonId
            };

        }
    }
}

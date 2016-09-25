using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.ApiModels
{
    public class Result
    {
        public string CompetitionId { get; set; }
        public string EventId { get; set; }
        public string RoundId { get; set; }
        public short Pos { get; set; }
        public int Best { get; set; }
        public int Average { get; set; }
        public string PersonName { get; set; }
        public string PersonId { get; set; }
        public string PersonCountryId { get; set; }
        public string FormatId { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }
        public int Value5 { get; set; }
        public string RegionalSingleRecord { get; set; }
        public string RegionalAverageRecord { get; set; }

        internal static Result Map(Results results)
        {
            if (results == null)
                return new Result();
            return new Result()
            {
                Average = results.Average,
                Best = results.Best,
                CompetitionId = results.CompetitionId,
                EventId = results.EventId,
                FormatId = results.FormatId,
                PersonCountryId = results.PersonCountryId,
                PersonId = results.PersonId,
                PersonName = results.PersonName,
                Pos = results.Pos,
                RegionalAverageRecord = results.RegionalAverageRecord,
                RegionalSingleRecord = results.RegionalSingleRecord,
                RoundId = results.RoundId,
                Value1 = results.Value1,
                Value2 = results.Value2,
                Value3 = results.Value3,
                Value4 = results.Value4,
                Value5 = results.Value5
            };
        }
    }
}

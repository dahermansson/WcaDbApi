using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class ResultsDiff
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
    }
}

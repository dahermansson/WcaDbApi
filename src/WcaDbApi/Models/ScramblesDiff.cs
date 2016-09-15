using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class ScramblesDiff
    {
        public long ScrambleId { get; set; }
        public string CompetitionId { get; set; }
        public string EventId { get; set; }
        public string RoundId { get; set; }
        public string GroupId { get; set; }
        public byte IsExtra { get; set; }
        public int ScrambleNum { get; set; }
        public string Scramble { get; set; }
    }
}

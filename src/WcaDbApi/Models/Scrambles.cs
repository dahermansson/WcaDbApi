using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class Scrambles
    {
        public long ScrambleId { get; set; }
        public string CompetitionId { get; set; }
        public string EventId { get; set; }
        public string RoundId { get; set; }
        public string GroupId { get; set; }
        public byte IsExtra { get; set; }
        public int ScrambleNum { get; set; }
        public string Scramble { get; set; }

        public virtual Competitions Competition { get; set; }
        public virtual Events Event { get; set; }
        public virtual Rounds Round { get; set; }
    }
}

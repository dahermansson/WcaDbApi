using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WcaDbApi.ApiModels
{
    public class Scramble
    {
        public long ScrambleId { get; set; }
        public string CompetitionId { get; set; }
        public string EventId { get; set; }
        public string RoundId { get; set; }
        public string GroupId { get; set; }
        public byte IsExtra { get; set; }
        public int ScrambleNum { get; set; }
        public string ScrambleSequence { get; set; }
    }
}

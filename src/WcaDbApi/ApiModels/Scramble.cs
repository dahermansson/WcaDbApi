using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

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

        internal static Scramble Map(Scrambles scrambles)
        {
            if (scrambles == null)
                return new Scramble();
            return new Scramble()
            {
                CompetitionId = scrambles.CompetitionId,
                EventId = scrambles.EventId,
                GroupId = scrambles.GroupId,
                IsExtra = scrambles.IsExtra,
                RoundId = scrambles.RoundId,
                ScrambleId = scrambles.ScrambleId,
                ScrambleNum = scrambles.ScrambleNum,
                ScrambleSequence = scrambles.Scramble
            };
        }
    }
}

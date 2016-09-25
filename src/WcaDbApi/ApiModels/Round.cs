using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.ApiModels
{
    public class Round
    {
        public string Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public string CellName { get; set; }
        public int Final { get; set; }

        internal static Round Map(Rounds rounds)
        {
            if (rounds == null)
                return new Round();
            return new Round()
            {
                Id = rounds.Id,
                Name = rounds.Name,
                CellName = rounds.CellName,
                Final = rounds.Final,
                Rank = rounds.Rank
            };
        }
    }
}

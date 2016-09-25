using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.ApiModels
{
    public class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public string Format { get; set; }
        public string CellName { get; set; }

        public static Event Map(Events events)
        {
            if (events == null)
                return new Event();
            return new Event()
            {
                Id = events.Id,
                CellName = events.CellName,
                Format = events.Format,
                Name = events.Name,
                Rank = events.Rank
            };
        }
    }
}

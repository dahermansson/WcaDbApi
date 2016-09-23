using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class EventController: Controller
    {
        private readonly WCADBContext _context;
        public EventController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events.Select(t => new Event()
            {
                Id = t.Id,
                CellName = t.CellName,
                Format = t.Format,
                Name = t.Name,
                Rank = t.Rank
            });
        }
    }
}

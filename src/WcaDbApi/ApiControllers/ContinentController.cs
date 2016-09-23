using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class ContinentController: Controller
    {
        private readonly WCADBContext _context;
        public ContinentController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Continent> Get()
        {
            return _context.Continents.Select(t => new Continent()
            {
                Id = t.Id,
                Name = t.Name,
                Latitude = t.Latitude,
                Longitude = t.Longitude,
                RecordName = t.RecordName,
                Zoom = t.Zoom
            });
        }
    }
}

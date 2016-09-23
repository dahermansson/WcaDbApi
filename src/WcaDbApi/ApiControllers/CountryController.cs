using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class CountryController: Controller
    {
        private readonly WCADBContext _context;
        public CountryController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return _context.Countries.Select(t => new Country()
            {
                Id = t.Id,
                Name = t.Name,
                Latitude = t.Latitude,
                Longitude = t.Longitude,
                Zoom = t.Zoom,
                ContinentId = t.ContinentId,
                Iso2 = t.Iso2
            });
        }
    }
}

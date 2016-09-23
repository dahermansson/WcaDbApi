using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class CompetitionController: Controller
    {
        private readonly WCADBContext _context;
        public CompetitionController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Competition> Get()
        {
            return _context.Competitions.Select(t => new Competition()
            {
                Id = t.Id,
                CellName = t.CellName,
                Name = t.Name,
                CityName = t.CityName,
                CountryId = t.CountryId,
                Day = t.Day,
                EndDay = t.EndDay,
                EndMonth = t.EndMonth,
                EventSpecs = t.EventSpecs,
                External_website = t.External_website,
                Information = t.Information,
                Latitude = t.Latitude,
                Longitude = t.Longitude,
                Month = t.Month,
                Organiser = t.Organiser,
                Venue = t.Venue,
                VenueAddress = t.VenueAddress,
                VenueDetails = t.VenueDetails,
                WcaDelegate = t.WcaDelegate,
                Year = t.Year
            });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class RankAvaregeController: Controller
    {
        private readonly WCADBContext _context;
        public RankAvaregeController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<RankAverage> Get()
        {
            return _context.RanksAverage.Select(t => new RankAverage()
            {
                Best = t.Best,
                ContinentRank = t.ContinentRank,
                CountryRank = t.CountryRank,
                WorldRank = t.WorldRank,
                EventId = t.EventId,
                PersonId = t.PersonId
            });
        }
    }
}

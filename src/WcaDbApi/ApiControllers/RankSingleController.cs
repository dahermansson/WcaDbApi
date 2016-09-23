using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class RankSingleController: Controller
    {
        private readonly WCADBContext _context;
        public RankSingleController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<RankSingle> Get()
        {
            return _context.RanksSingle.Select(t => new RankSingle()
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

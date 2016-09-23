using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class RoundController: Controller
    {
        private readonly WCADBContext _context;
        public RoundController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Round> Get()
        {
            return _context.Rounds.Select(t => new Round()
            {
                Id = t.Id,
                Name = t.Name,
                CellName = t.CellName,
                Final = t.Final,
                Rank = t.Rank
            });
        }
    }
}

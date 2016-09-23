using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class ScrambleController: Controller
    {
        private readonly WCADBContext _context;
        public ScrambleController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Scramble> Get(string id)
        {
            return _context.Scrambles.Where(t => t.CompetitionId == id).Select(t => new Scramble()
            {
                CompetitionId = t.CompetitionId,
                EventId = t.EventId,
                GroupId = t.GroupId,
                IsExtra = t.IsExtra,
                RoundId = t.RoundId,
                ScrambleId = t.ScrambleId,
                ScrambleNum = t.ScrambleNum,
                ScrambleSequence = t.Scramble
            });
        }
    }
}

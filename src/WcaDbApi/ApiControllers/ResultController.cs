using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class ResultController: Controller
    {
        private readonly WCADBContext _context;
        public ResultController(WCADBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Result> Get(string id)
        {
            return _context.Results.Where(t => t.CompetitionId.ToLower() == id.ToLower()).Select(t => new Result()
            {
                Average = t.Average,
                Best = t.Best,
                CompetitionId = t.CompetitionId,
                EventId = t.EventId,
                FormatId = t.FormatId,
                PersonCountryId = t.PersonCountryId,
                PersonId = t.PersonId,
                PersonName = t.PersonName,
                Pos = t.Pos,
                RegionalAverageRecord = t.RegionalAverageRecord,
                RegionalSingleRecord = t.RegionalSingleRecord,
                RoundId = t.RoundId,
                Value1 = t.Value1,
                Value2 = t.Value2,
                Value3 = t.Value3,
                Value4 = t.Value4,
                Value5 = t.Value5
            });
        }

        [HttpGet]
        public IEnumerable<Result> GetByPersonId(string id)
        {
            return _context.Results.Where(t => t.PersonId.ToLower() == id.ToLower()).Select(t => new Result()
            {
                Average = t.Average,
                Best = t.Best,
                CompetitionId = t.CompetitionId,
                EventId = t.EventId,
                FormatId = t.FormatId,
                PersonCountryId = t.PersonCountryId,
                PersonId = t.PersonId,
                PersonName = t.PersonName,
                Pos = t.Pos,
                RegionalAverageRecord = t.RegionalAverageRecord,
                RegionalSingleRecord = t.RegionalSingleRecord,
                RoundId = t.RoundId,
                Value1 = t.Value1,
                Value2 = t.Value2,
                Value3 = t.Value3,
                Value4 = t.Value4,
                Value5 = t.Value5
            });
        }
    }
}

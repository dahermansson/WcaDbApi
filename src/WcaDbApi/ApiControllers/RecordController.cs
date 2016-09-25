using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WcaDbApi.Models;
using WcaDbApi.ApiModels;

namespace WcaDbApi.ApiControllers
{
    public class RecordController : Controller
    {
        private readonly WCADBContext _context;
        public RecordController(WCADBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Result> Get()
        {
            return _context.Results.Where(t => t.RegionalAverageRecord != string.Empty || t.RegionalSingleRecord != string.Empty).Select(t => new Result()
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
        public IEnumerable<Result> GetNR(string country = "Sweden")
        {
            var NR = _context.Results.Where(rec => rec.EventId != "mmagic" &&
                                            rec.EventId != "magic" &&
                                            rec.PersonCountryId == country &&
                                            rec.RegionalAverageRecord.EndsWith("R"))
                     .GroupBy(rec => rec.EventId).Select(s => s.OrderBy(t => t.Average)).Select(s => s.First()).Select(t => new Result() {
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
                     } );
            return NR;
        }
    }
}

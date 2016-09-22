using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WcaDbApi.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WcaDbApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class Records : Controller
    {
        private readonly WCADBContext _context;
        public Records(WCADBContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Results> GetNR(string country = "Sweden", string recordType = "NR")
        {
            var NR = _context.Results.Where(rec => rec.EventId != "mmagic" &&
                                            rec.EventId != "magic" &&
                                            rec.PersonCountryId == country &&
                                            rec.RegionalAverageRecord == recordType)
                     .GroupBy(rec => rec.EventId).Select(s => s.OrderBy(t => t.Average)).Select(s => s.First()).ToList();
            return NR;
        }
    }
}

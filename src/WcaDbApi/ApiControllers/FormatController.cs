using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class FormatController: Controller
    {
        private readonly WCADBContext _context;
        public FormatController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Format> Get()
        {
            return _context.Formats.Select(t => new Format()
            {
                Id = t.Id,
                Name = t.Name,
                Expected_solve_count = t.Expected_solve_count,
                Sort_by = t.Sort_by,
                Sort_by_second = t.Sort_by_second,
                Trim_fastest_n = t.Trim_fastest_n,
                Trim_slowest_n = t.Trim_slowest_n
            });
        }
    }
}

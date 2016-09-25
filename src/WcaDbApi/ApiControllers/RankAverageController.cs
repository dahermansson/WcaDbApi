using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.ApiServices.Interfaces;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class RankAvaregeController: Controller
    {
        private readonly IResultsService _service;
        public RankAvaregeController(IResultsService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<RankAverage> Get()
        {
            return _service.GetRankAverages();
        }
    }
}

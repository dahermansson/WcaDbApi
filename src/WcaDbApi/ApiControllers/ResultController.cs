using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.ApiServices.Interfaces;

namespace WcaDbApi.ApiControllers
{
    public class ResultController: Controller
    {
        private readonly IResultsService _service;
        public ResultController(IResultsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Result> Get(string id)
        {
            return _service.GetResultsByCompetitionId(id);
        }

        [HttpGet]
        public IEnumerable<Result> GetByPersonId(string id)
        {
            return _service.GetResultsByPersonId(id);
        }
    }
}

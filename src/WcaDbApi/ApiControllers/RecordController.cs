using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WcaDbApi.Models;
using WcaDbApi.ApiModels;
using WcaDbApi.ApiServices.Interfaces;

namespace WcaDbApi.ApiControllers
{
    public class RecordController : Controller
    {
        private readonly IResultsService _serivce;
        public RecordController(IResultsService service)
        {
            _serivce = service;
        }

        [HttpGet]
        public IEnumerable<Result> Get()
        {
            return _serivce.GetRecords();
        }

        [HttpGet]
        public IEnumerable<Result> GetCurrentNationalRecords(string countryId = "Sweden")
        {
            return _serivce.GetCurrentNationalRecords(countryId);
        }
    }
}

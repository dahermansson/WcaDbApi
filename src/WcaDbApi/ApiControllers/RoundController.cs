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
    public class RoundController: Controller
    {
        private readonly IMiscService _serivce;
        public RoundController(IMiscService service)
        {
            _serivce = service;
        }
        [HttpGet]
        public IEnumerable<Round> Get()
        {
            return _serivce.GetRounds();
        }
    }
}

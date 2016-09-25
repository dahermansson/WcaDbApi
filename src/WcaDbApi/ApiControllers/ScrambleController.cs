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
    public class ScrambleController: Controller
    {
        private readonly IMiscService _service;
        public ScrambleController(IMiscService serivce)
        {
            _service = serivce;
        }
        [HttpGet]
        public IEnumerable<Scramble> Get(string id)
        {
            return _service.GetScrambles(id);
        }
    }
}

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
    public class CountryController: Controller
    {
        private readonly IMiscService _service;
        public CountryController(IMiscService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return _service.GetCountries();
        }
    }
}

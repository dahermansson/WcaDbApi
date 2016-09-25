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
    public class PersonController: Controller
    {
        private readonly IPersonsService _service;
        public PersonController(IPersonsService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _service.Get();
        }
        [HttpGet]
        public Person GetByIdAndSubId(string id, byte subId)
        {
            return _service.GetByPersonId(id, subId);
        }
    }
}

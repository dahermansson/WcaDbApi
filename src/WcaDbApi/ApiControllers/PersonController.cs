using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;

namespace WcaDbApi.ApiControllers
{
    public class PersonController: Controller
    {
        private readonly WCADBContext _context;
        public PersonController(WCADBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _context.Persons.Select(t => new Person()
            {
                Id = t.Id,
                Name = t.Name,
                CountryId = t.CountryId,
                Gender = t.Gender,
                Subid = t.Subid
            });
        }
    }
}

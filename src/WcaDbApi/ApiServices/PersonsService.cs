using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;
using WcaDbApi.ApiServices.Interfaces;

namespace WcaDbApi.ApiServices
{
    public class PersonsService : IPersonsService
    {
        private readonly WCADBContext _context;
        public PersonsService(WCADBContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> Get()
        {
            return _context.Persons.Select(t => Person.Map(t));
        }

        public Person GetByPersonId(string id, byte subId)
        {
            return Person.Map(_context.Persons.FirstOrDefault(p => p.Id.ToUpper() == id.ToUpper() && p.Subid == subId));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.ApiModels
{
    public class Person
    {
        public string Id { get; set; }
        public byte Subid { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public string Gender { get; set; }

        internal static Person Map(Persons persons)
        {
            if (persons == null)
                return new Person();
            return new Person()
            {
                Id = persons.Id,
                Name = persons.Name,
                CountryId = persons.CountryId,
                Gender = persons.Gender,
                Subid = persons.Subid
            };
        }
    }
}

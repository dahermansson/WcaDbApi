using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WcaDbApi.ApiModels
{
    public class Person
    {
        public string Id { get; set; }
        public byte Subid { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public string Gender { get; set; }
    }
}

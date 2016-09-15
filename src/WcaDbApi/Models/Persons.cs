using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class Persons
    {
        public string Id { get; set; }
        public byte Subid { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public string Gender { get; set; }

        public virtual Countries Country { get; set; }
    }
}

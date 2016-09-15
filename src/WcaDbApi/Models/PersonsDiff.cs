using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class PersonsDiff
    {
        public string Id { get; set; }
        public byte Subid { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public string Gender { get; set; }
    }
}

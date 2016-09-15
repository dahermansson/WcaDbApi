using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class Continents
    {
        public Continents()
        {
            Countries = new HashSet<Countries>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string RecordName { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public byte Zoom { get; set; }

        public virtual ICollection<Countries> Countries { get; set; }
    }
}

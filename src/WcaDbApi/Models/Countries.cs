using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Competitions = new HashSet<Competitions>();
            Persons = new HashSet<Persons>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string ContinentId { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public byte Zoom { get; set; }
        public string Iso2 { get; set; }

        public virtual ICollection<Competitions> Competitions { get; set; }
        public virtual ICollection<Persons> Persons { get; set; }
        public virtual Continents Continent { get; set; }
    }
}

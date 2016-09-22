using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class Competitions
    {
        public Competitions()
        {
            Scrambles = new HashSet<Scrambles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
        public string CountryId { get; set; }
        public string Information { get; set; }
        public short Year { get; set; }
        public short Month { get; set; }
        public short Day { get; set; }
        public short EndMonth { get; set; }
        public short EndDay { get; set; }
        public string EventSpecs { get; set; }
        public string WcaDelegate { get; set; }
        public string Organiser { get; set; }
        public string Venue { get; set; }
        public string VenueAddress { get; set; }
        public string VenueDetails { get; set; }
        public string External_website { get; set; }
        public string CellName { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public virtual ICollection<Scrambles> Scrambles { get; set; }
        public virtual Countries Country { get; set; }
    }
}

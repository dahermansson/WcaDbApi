using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.ApiModels
{
    public class Continent
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RecordName { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public byte Zoom { get; set; }

        public static Continent Map(Continents continents)
        {
            if (continents == null)
                return new Continent();
            return new Continent()
            {
                Id = continents.Id,
                Name = continents.Name,
                Latitude = continents.Latitude,
                Longitude = continents.Longitude,
                RecordName = continents.RecordName,
                Zoom = continents.Zoom
            };
        }
    }
}

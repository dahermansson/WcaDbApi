using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.ApiModels
{
    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ContinentId { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public byte Zoom { get; set; }
        public string Iso2 { get; set; }

        public static Country Map(Countries counties)
        {
            if (counties == null)
                return new Country();
            return new Country()
            {
                Id = counties.Id,
                Name = counties.Name,
                Latitude = counties.Latitude,
                Longitude = counties.Longitude,
                Zoom = counties.Zoom,
                ContinentId = counties.ContinentId,
                Iso2 = counties.Iso2
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.ApiModels
{
    public class Competition
    {
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

        internal static Competition Map(Competitions competitions)
        {
            if (competitions == null)
                return new Competition();
            return new Competition()
            {
                Id = competitions.Id,
                CellName = competitions.CellName,
                Name = competitions.Name,
                CityName = competitions.CityName,
                CountryId = competitions.CountryId,
                Day = competitions.Day,
                EndDay = competitions.EndDay,
                EndMonth = competitions.EndMonth,
                EventSpecs = competitions.EventSpecs,
                External_website = competitions.External_website,
                Information = competitions.Information,
                Latitude = competitions.Latitude,
                Longitude = competitions.Longitude,
                Month = competitions.Month,
                Organiser = competitions.Organiser,
                Venue = competitions.Venue,
                VenueAddress = competitions.VenueAddress,
                VenueDetails = competitions.VenueDetails,
                WcaDelegate = competitions.WcaDelegate,
                Year = competitions.Year
            };
        }
    }
}

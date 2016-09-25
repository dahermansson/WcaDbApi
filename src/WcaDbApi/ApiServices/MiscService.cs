using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;
using WcaDbApi.ApiServices.Interfaces;

namespace WcaDbApi.ApiServices
{
    public class MiscService : IMiscService
    {
        private readonly WCADBContext _context;
        public MiscService(WCADBContext context)
        {
            _context = context;
        }

        public Competition GetCompetition()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Competition> GetCompetitions()
        {
            return _context.Competitions.Select(t => Competition.Map(t));
        }

        public Continent GetContinent(string id)
        {
            return Continent.Map(_context.Continents.FirstOrDefault(c => c.Id == id));
        }

        public IEnumerable<Continent> GetContinents()
        {
            return _context.Continents.Select(t => Continent.Map(t));
        }

        public Country GetContry(string id)
        {
            return Country.Map(_context.Countries.FirstOrDefault(c => c.Id == id));
        }

        public IEnumerable<Country> GetCountries()
        {
            return _context.Countries.Select(t => Country.Map(t));
        }

        public Event GetEvent(string id)
        {
            return Event.Map(_context.Events.FirstOrDefault(e => e.Id == id));
        }

        public IEnumerable<Event> GetEvents()
        {
            return _context.Events.Select(t => Event.Map(t));
        }

        public Format GetFormat(string id)
        {
            return Format.Map(_context.Formats.FirstOrDefault(f => f.Id == id));
        }

        public IEnumerable<Format> GetFormats()
        {
            return _context.Formats.Select(t => Format.Map(t));
        }

        public Round GetRound(string id)
        {
            return Round.Map(_context.Rounds.FirstOrDefault(r => r.Id == id));
        }

        public IEnumerable<Round> GetRounds()
        {
            return _context.Rounds.Select(t => Round.Map(t) );
        }

        public Scramble GetScramble(long id)
        {
            return Scramble.Map(_context.Scrambles.FirstOrDefault(s => s.ScrambleId == id));
        }

        public IEnumerable<Scramble> GetScrambles(string competitionId)
        {
            return _context.Scrambles.Where(t => t.CompetitionId == competitionId).Select(t => Scramble.Map(t));
        }
    }
}

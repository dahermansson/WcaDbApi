using System.Collections.Generic;
using WcaDbApi.ApiModels;

namespace WcaDbApi.ApiServices.Interfaces
{
    public interface IMiscService
    {
        IEnumerable<Continent> GetContinents();
        Continent GetContinent(string id);
        IEnumerable<Country> GetCountries();
        Country GetContry(string id);
        IEnumerable<Competition> GetCompetitions();
        Competition GetCompetition();
        IEnumerable<Event> GetEvents();
        Event GetEvent(string id);
        IEnumerable<Format> GetFormats();
        Format GetFormat(string id);
        IEnumerable<Round> GetRounds();
        Round GetRound(string id);
        IEnumerable<Scramble> GetScrambles(string competitionId);
        Scramble GetScramble(long id);



    }
}

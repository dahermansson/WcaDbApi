using System.Collections.Generic;
using WcaDbApi.ApiModels;

namespace WcaDbApi.ApiServices.Interfaces
{
    public interface IResultsService
    {
        IEnumerable<Result> GetResultsByCompetitionId(string competitionId);
        IEnumerable<Result> GetResultsByPersonId(string personId);
        IEnumerable<RankAverage> GetRankAverages();
        IEnumerable<RankSingle> GetRankSingles();
    }
}

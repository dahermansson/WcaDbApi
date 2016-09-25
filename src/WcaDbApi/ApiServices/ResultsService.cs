using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;
using WcaDbApi.Models;
using WcaDbApi.ApiServices.Interfaces;

namespace WcaDbApi.ApiServices
{
    public class ResultsService : IResultsService
    {
        private readonly WCADBContext _context;
        public ResultsService(WCADBContext context)
        {
            _context = context;
        }

        public IEnumerable<RankAverage> GetRankAverages()
        {
            return _context.RanksAverage.Select(t => RankAverage.Map(t));
        }

        public IEnumerable<RankSingle> GetRankSingles()
        {
            return _context.RanksSingle.Select(t => RankSingle.Map(t));
        }

        public IEnumerable<Result> GetResultsByCompetitionId(string competitionId)
        {
            return _context.Results.Where(t => t.CompetitionId.ToLower() == competitionId.ToLower()).Select(t => Result.Map(t));
        }

        public IEnumerable<Result> GetResultsByPersonId(string id)
        {
            return _context.Results.Where(t => t.PersonId.ToLower() == id.ToLower()).Select(t => Result.Map(t));
        }
    }
}

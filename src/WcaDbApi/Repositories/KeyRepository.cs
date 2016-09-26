using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;
using WcaDbApi.Repositories.Interfaces;

namespace WcaDbApi.Repositories
{
    public class KeyRepository : IKeyRepository
    {
        private readonly WCADBContext _context;
        public KeyRepository(WCADBContext context)
        {
            _context = context;
        }
        public void CreateKey(Key key)
        {
            _context.Key.Add(key);
            _context.SaveChanges();
        }

        public bool VerifyKey(Guid apikey)
        {
            return _context.Key.Any(key => key.ApiKey == apikey && !key.BannedKey);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Models;

namespace WcaDbApi.Repositories.Interfaces
{
    public interface IKeyRepository
    {
        void CreateKey(Key key);
        bool VerifyKey(Guid key);
    }
}

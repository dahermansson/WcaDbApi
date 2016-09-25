using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.ApiModels;

namespace WcaDbApi.ApiServices.Interfaces
{
    public interface IPersonsService
    {
        IEnumerable<Person> Get();
        Person GetByPersonId(string id, byte subId);
    }
}

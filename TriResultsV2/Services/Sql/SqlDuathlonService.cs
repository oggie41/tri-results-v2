using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Sql
{
    public class SqlDuathlonService : IDuathlonService
    {
        public async Task<IEnumerable<MultisportEventResult>> GetResultsAsync()
        {
            var eventResults = new List<MultisportEventResult>();
            return eventResults;
        }
    }
}

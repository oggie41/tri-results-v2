using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Sql
{
    public class SqlSwimService : ISwimService
    {
        public async Task<IEnumerable<EventResult>> Get200MetreTTResultsAsync()
        {
            var eventResults = new List<EventResult>();
            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> Get400MetreTTResultsAsync()
        {
            var eventResults = new List<EventResult>();
            return eventResults;
        }
    }
}

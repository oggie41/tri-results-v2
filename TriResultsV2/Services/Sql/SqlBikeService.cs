using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Sql
{
    public class SqlBikeService : IBikeService
    {
        public async Task<IEnumerable<EventResult>> Get10MileTTResultsAsync()
        {
            await Task.Delay(500);

            var eventResults = new List<EventResult>();
            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> Get25MileTTResultsAsync()
        {
            await Task.Delay(500);

            var eventResults = new List<EventResult>();
            return eventResults;
        }
    }
}

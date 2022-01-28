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
        public async Task<IEnumerable<EventResult>> GetCssTestResultsAsync()
        {
            await Task.Delay(500);

            var eventResults = new List<EventResult>();
            return eventResults;
        }
    }
}

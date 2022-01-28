using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Sql
{
    public class SqlRunService : IRunService
    {
        public async Task<IEnumerable<EventResult>> Get5KResultsAsync()
        {
            await Task.Delay(500);

            var eventResults = new List<EventResult>();
            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> Get10KResultsAsync()
        {
            await Task.Delay(500);

            var eventResults = new List<EventResult>();
            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> GetHalfMarathonResultsAsync()
        {
            await Task.Delay(500);

            var eventResults = new List<EventResult>();
            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> GetMultiStageResultsAsync()
        {
            await Task.Delay(500);

            var eventResults = new List<EventResult>();
            return eventResults;
        }
    }
}

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
            var eventResults = new List<EventResult>();
            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> Get10KResultsAsync()
        {
            var eventResults = new List<EventResult>();
            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> GetHalfMarathonResultsAsync()
        {
            var eventResults = new List<EventResult>();
            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> GetMultiStageResultsAsync()
        {
            var eventResults = new List<EventResult>();
            return eventResults;
        }
    }
}

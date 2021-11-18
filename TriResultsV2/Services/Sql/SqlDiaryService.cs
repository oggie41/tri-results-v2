using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Sql
{
    public class SqlDiaryService : IDiaryService
    {
        public async Task<IEnumerable<PlannedEvent>> GetPlannedEventsAsync()
        {
            var plannedEvents = new List<PlannedEvent>();
            return plannedEvents;
        }
    }
}

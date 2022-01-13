using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Local
{
    public class LocalDiaryService : IDiaryService
    {
        public async Task<IEnumerable<PlannedEvent>> GetPlannedEventsAsync()
        {
            var plannedEvents = new List<PlannedEvent>();

            var plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 7, 13),
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventName = "Doncaster 5K 2022",
                EventUrl = "https://www.doncasterathleticclub.com/doncaster-5k/",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 4, 23),
                Sport = SportType.Duathlon,
                EventName = "Clumber Sprint Duathlon 2022",
                EventUrl = "https://www.trisociety.co.uk/events/clumber-park-duathlon/",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2021, 12, 5),
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventName = "Percy Pud 10K 2021",
                EventUrl = "https://www.steelcitystriders.co.uk/percy-pud-10k/",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            return plannedEvents;
        }
    }
}

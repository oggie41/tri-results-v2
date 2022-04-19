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
        public Task<IEnumerable<PlannedEvent>> GetPlannedEventsAsync()
        {
            var plannedEvents = new List<PlannedEvent>();

            PlannedEvent plannedEvent;

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 9, 3),
                Sport = SportType.Bike,
                EventName = "The Peaks Tour Sportive",
                Distance = 75,
                DistanceUnit = DistanceUnit.Miles,
                EventUrl = "https://www.ukcyclingevents.co.uk/products/the-peaks-tour-sportive",
                Entered = false
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 8, 24),
                Sport = SportType.Duathlon,
                Course = Course.ScunthorpeSummerDuathlonBurringham,
                EventUrl = "https://www.facebook.com/groups/1858449397787749/",
                Entered = false
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 8, 7),
                Sport = SportType.Triathlon,
                Course = Course.BassetlawSprintTriathlon,
                EventUrl = "https://www.bassetlawtriclub.co.uk/triathlon",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 7, 27),
                Sport = SportType.Duathlon,
                Course = Course.ScunthorpeSummerDuathlonBurringham,
                EventUrl = "https://www.facebook.com/groups/1858449397787749/",
                Entered = false
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 7, 13),
                Sport = SportType.Run,
                Course = Course.Doncaster5K,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventUrl = "https://www.doncasterathleticclub.com/doncaster-5k/",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 6, 26),
                Sport = SportType.Run,
                Course = Course.RoundSheffieldRun,
                Distance = 20,
                DistanceUnit = DistanceUnit.Kilometres,
                EventName = "Round Sheffield Run 2022 (w/ Scott)",
                EventUrl = "https://www.roundsheffieldrun.com/",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 5, 4),
                Sport = SportType.Run,
                Course = Course.LoxleyLash5K,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventUrl = "https://www.sheffieldrunningclub.org.uk/racing/our-hosted-races/loxley-lash/",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 4, 23),
                Sport = SportType.Duathlon,
                Course = Course.ClumberSprintDuathlon,
                EventUrl = "https://resultsbase.net/event/5943",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2022, 4, 10),
                Sport = SportType.Run,
                Course = Course.YorkBigFlatRunway10K,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventUrl = "https://evensplits.events/big-flat-race",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            //plannedEvent = new PlannedEvent
            //{
            //    EventDate = new DateTime(2022, 3, 6),
            //    Sport = SportType.Run,
            //    Distance = 13.1,
            //    DistanceUnit = DistanceUnit.Miles,
            //    EventName = "Retford Half Marathon 2022",
            //    EventUrl = "https://bookitzone.com/RetfordHalf/PwjFFX",
            //    Entered = false
            //};
            //plannedEvents.Add(plannedEvent);

            plannedEvent = new PlannedEvent
            {
                EventDate = new DateTime(2021, 12, 5),
                Sport = SportType.Run,
                Course = Course.PercyPud10K,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventUrl = "https://www.steelcitystriders.co.uk/percy-pud-10k/",
                Entered = true
            };
            plannedEvents.Add(plannedEvent);

            return Task.FromResult(plannedEvents.AsEnumerable());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Local
{
    public class LocalBikeService : IBikeService
    {
        public async Task<IEnumerable<EventResult>> Get10MileTTResultsAsync()
        {
            var eventResults = new List<EventResult>();

            var bikeResult2684332277 = new EventResult
            {
                Id = 2684332277,
                GarminId = 2684332277,
                Sport = SportType.Bike,
                Distance = EventHelper.Distance10Miles,
                EventDate = new DateTime(2018, 5, 8),
                EventName = "Cuckney 10 Mile TT",
                TotalTime = new TimeSpan(0, 27, 00),
                AvgPaceSpeed = "22.2 mph",
                PersonalBest = true
            };
            eventResults.Add(bikeResult2684332277);

            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> Get25MileTTResultsAsync()
        {
            var eventResults = new List<EventResult>();

            var bikeResult3448107371 = new EventResult
            {
                Id = 3448107371,
                GarminId = 3448107371,
                Sport = SportType.Bike,
                Distance = EventHelper.Distance25Miles,
                EventDate = new DateTime(2019, 3, 9),
                EventName = "Sheffrec CC 2-Up 25 Mile TT",
                TotalTime = new TimeSpan(1, 17, 40),
                AvgPaceSpeed = "19.3 mph"
            };
            eventResults.Add(bikeResult3448107371);

            return eventResults;
        }
    }
}

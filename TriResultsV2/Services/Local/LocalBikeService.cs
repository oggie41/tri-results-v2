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
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                TimeTrial = true,
                EventDate = new DateTime(2018, 5, 8),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 00),
                AvgBikeSpeedMph = 22.2,
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
                Distance = 25,
                DistanceUnit = DistanceUnit.Miles,
                TimeTrial = true,
                EventDate = new DateTime(2019, 3, 9),
                EventName = "Sheffrec CC 2-Up 25mi TT (with Greg)",
                Course = Course.Hatfield25MileTT,
                TotalTime = new TimeSpan(1, 17, 40),
                AvgBikeSpeedMph = 19.3
            };
            eventResults.Add(bikeResult3448107371);

            return eventResults;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Local
{
    public class LocalSwimService : ISwimService
    {
        public async Task<IEnumerable<EventResult>> Get200MetreTTResultsAsync()
        {
            var eventResults = new List<EventResult>();

            var result = new EventResult
            {
                Id = 3221940710,
                GarminId = 3221940710,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2018, 12, 12),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 18),
                PersonalBest = true
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1647266045,
                GarminId = 1647266045,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2017, 3, 29),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 21)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1586996421,
                GarminId = 1586996421,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2017, 2, 23),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 26)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 984904552,
                GarminId = 984904552,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2015, 12, 16),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 29)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 940902079,
                GarminId = 940902079,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2015, 10, 28),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 29)
            };
            eventResults.Add(result);

            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> Get400MetreTTResultsAsync()
        {
            var eventResults = new List<EventResult>();

            var result = new EventResult
            {
                Id = 3221940710,
                GarminId = 3221940710,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2018, 12, 12),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 6, 52),
                PersonalBest = true
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1647266045,
                GarminId = 1647266045,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2017, 3, 29),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 6, 56)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1586996421,
                GarminId = 1586996421,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2017, 2, 23),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 7, 23)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 984904552,
                GarminId = 984904552,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2015, 12, 16),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 7, 25)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 940902079,
                GarminId = 940902079,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                TimeTrial = true,
                EventDate = new DateTime(2015, 10, 28),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 7, 21)
            };
            eventResults.Add(result);

            return eventResults;
        }
    }
}

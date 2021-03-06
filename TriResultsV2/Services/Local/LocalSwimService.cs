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
        public Task<IEnumerable<EventResult>> GetCssTestResultsAsync()
        {
            var eventResults = new List<EventResult>();

            EventResult result;

            // CSS Test on 12/12/2018.
            result = new EventResult
            {
                Id = 3221940710,
                GarminId = 3221940710,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2018, 12, 12),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 18)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 3221940710,
                GarminId = 3221940710,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2018, 12, 12),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 6, 52)
            };
            eventResults.Add(result);

            // CSS Test on 29/03/2017.
            result = new EventResult
            {
                Id = 1647266045,
                GarminId = 1647266045,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2017, 3, 29),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 21)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1647266045,
                GarminId = 1647266045,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2017, 3, 29),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 6, 56)
            };
            eventResults.Add(result);

            // CSS Test on 23/02/2017.
            result = new EventResult
            {
                Id = 1586996421,
                GarminId = 1586996421,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2017, 2, 23),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 26)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1586996421,
                GarminId = 1586996421,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2017, 2, 23),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 7, 23)
            };
            eventResults.Add(result);

            // CSS Test on 16/12/2015.
            result = new EventResult
            {
                Id = 984904552,
                GarminId = 984904552,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2015, 12, 16),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 29)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 984904552,
                GarminId = 984904552,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2015, 12, 16),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 7, 25)
            };
            eventResults.Add(result);

            // CSS Test on 28/10/2015.
            result = new EventResult
            {
                Id = 940902079,
                GarminId = 940902079,
                Sport = SportType.Swim,
                Distance = 200,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2015, 10, 28),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 3, 29)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 940902079,
                GarminId = 940902079,
                Sport = SportType.Swim,
                Distance = 400,
                DistanceUnit = DistanceUnit.Metres,
                EventDate = new DateTime(2015, 10, 28),
                Course = Course.Westfield,
                TotalTime = new TimeSpan(0, 7, 21)
            };
            eventResults.Add(result);

            SwimHelper.SetSwimPersonalBest(eventResults, 200);
            SwimHelper.SetSwimPersonalBest(eventResults, 400);

            return Task.FromResult(eventResults.AsEnumerable());
        }
    }
}

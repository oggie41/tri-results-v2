﻿using System;
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

            var swimResult3221940710 = new EventResult
            {
                Id = 3221940710,
                GarminId = 3221940710,
                Sport = SportType.Swim,
                Distance = EventHelper.Distance200Metres,
                EventDate = new DateTime(2018, 12, 12),
                EventName = "Westfield 200m TT",
                TotalTime = new TimeSpan(0, 3, 18),
                AvgPaceSpeed = "25.0 sec/25m",
                PersonalBest = true
            };
            eventResults.Add(swimResult3221940710);

            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> Get400MetreTTResultsAsync()
        {
            var eventResults = new List<EventResult>();

            var swimResult3221940710 = new EventResult
            {
                Id = 3221940710,
                GarminId = 3221940710,
                Sport = SportType.Swim,
                Distance = EventHelper.Distance400Metres,
                EventDate = new DateTime(2018, 12, 12),
                EventName = "Westfield 400m TT",
                TotalTime = new TimeSpan(0, 6, 52),
                AvgPaceSpeed = "26.0 sec/25m",
                PersonalBest = true
            };
            eventResults.Add(swimResult3221940710);

            return eventResults;
        }
    }
}

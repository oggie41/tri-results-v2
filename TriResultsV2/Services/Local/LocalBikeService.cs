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
        public Task<IEnumerable<EventResult>> Get10MileTTResultsAsync()
        {
            var eventResults = new List<EventResult>();

            EventResult result;

            result = new EventResult
            {
                Id = 2952900617,
                GarminId = 2952900617,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2018, 8, 21),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 9),
                AvgBikeSpeedMph = 22.1
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2915375857,
                GarminId = 2915375857,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2018, 8, 7),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 26),
                AvgBikeSpeedMph = 21.9
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2807860740,
                GarminId = 2807860740,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2018, 6, 26),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 15),
                AvgBikeSpeedMph = 22.0
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2737930095,
                GarminId = 2737930095,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2018, 5, 29),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 51),
                AvgBikeSpeedMph = 21.5
            };
            result.AddEventFigure("Strong headwind going out.", NamedIcon.Wind);
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2684332277,
                GarminId = 2684332277,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2018, 5, 8),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 0),
                AvgBikeSpeedMph = 22.2
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2632617143,
                GarminId = 2632617143,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2018, 4, 17),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 45),
                AvgBikeSpeedMph = 21.6
            };
            result.AddEventFigure("Added Fulcrum Quattro wheels.", NamedIcon.Gear);
            result.AddEventFigure("Strong headwind coming back.", NamedIcon.Wind);
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1947561200,
                GarminId = 1947561200,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2017, 8, 29),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 29),
                AvgBikeSpeedMph = 21.8
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1876799493,
                GarminId = 1876799493,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2017, 7, 25),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 7),
                AvgBikeSpeedMph = 22.1
            };
            result.AddEventFigure("Added aero helmet.", NamedIcon.Gear);
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1796732653,
                GarminId = 1796732653,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2017, 6, 13),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 31),
                AvgBikeSpeedMph = 21.8
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1769467964,
                GarminId = 1769467964,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2017, 5, 30),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 27, 57),
                AvgBikeSpeedMph = 21.5
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1754862185,
                GarminId = 1754862185,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2017, 5, 23),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 28, 25),
                AvgBikeSpeedMph = 21.1
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1724277940,
                GarminId = 1724277940,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2017, 5, 9),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 28, 9),
                AvgBikeSpeedMph = 21.3
            };
            result.AddEventFigure("Added aero bars.", NamedIcon.Gear);
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1711109551,
                GarminId = 1711109551,
                Sport = SportType.Bike,
                Distance = 10,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2017, 5, 2),
                Course = Course.Cuckney10MileTT,
                TotalTime = new TimeSpan(0, 29, 54),
                AvgBikeSpeedMph = 20.1
            };
            eventResults.Add(result);

            EventHelper.SetPersonalBest(eventResults);

            return Task.FromResult(eventResults.AsEnumerable());
        }

        public Task<IEnumerable<EventResult>> Get25MileTTResultsAsync()
        {
            var eventResults = new List<EventResult>();

            EventResult result;

            result = new EventResult
            {
                Id = 3448107371,
                GarminId = 3448107371,
                Sport = SportType.Bike,
                Distance = 25,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2019, 3, 9),
                EventName = "Sheffrec CC 2-Up 25mi TT (w/ Greg)",
                Course = Course.Hatfield25MileTT,
                TotalTime = new TimeSpan(1, 17, 40),
                AvgBikeSpeedMph = 19.3
            };
            result.AddEventFigure("Really tough conditions... 26mph winds!", NamedIcon.Wind);
            eventResults.Add(result);

            return Task.FromResult(eventResults.AsEnumerable());
        }
    }
}

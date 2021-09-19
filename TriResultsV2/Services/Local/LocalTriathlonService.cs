using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Local
{
    public class LocalTriathlonService : ITriathlonService
    {
        public async Task<IEnumerable<MultisportEventResult>> GetResultsAsync()
        {
            var eventResults = new List<MultisportEventResult>();

            var result7430411827 = new MultisportEventResult
            {
                Id = 7430411827,
                GarminId = 7430411827,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2021, 9, 5),
                EventName = "Bassetlaw Sprint Triathlon",
                Discipline1Distance = 400,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.Pool,
                Discipline2Distance = 25,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 8, 1),
                ActualSwimTime = new TimeSpan(0, 7, 22),
                T1Time = new TimeSpan(0, 1, 32),
                Discipline2Time = new TimeSpan(0, 43, 6),
                T2Time = new TimeSpan(0, 0, 55),
                Discipline3Time = new TimeSpan(0, 21, 8),
                TotalTime = new TimeSpan(1, 14, 44),
                Discipline2AvgBikeSpeedMph = 20.2,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 6, 53),
                TotalParticipants = 115,
                Discipline1Position = 28,
                T1Position = 73,
                Discipline2Position = 23,
                T2Position = 28,
                Discipline3Position = 23,
                OverallPosition = 22,
                Weather = WeatherType.SunnyCloudy,
                WeatherNotes = "18°C, Sunny/Cloudy, 5mph wind",
                EventNotes = "Great conditions. Swim went pretty well considering the lack of swim training.<br/>" +
                             "Good bike course, plenty of opportunity to get on the tri bars. Need to up the bike training really though, especially TT specific riding, didn't feel strong enough at times.<br/>" +
                             "Run was 2 laps around the local area. Felt pretty good and finished strongly. With more bike training should be able to perform better on the run as will feel fresher.<br/>" +
                             "Really enjoyed the race, definitely want to do it again next year.",
                Expanded = true
            };
            eventResults.Add(result7430411827);

            var result7226965095 = new MultisportEventResult
            {
                Id = 7226965095,
                GarminId = 7226965095,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2021, 8, 1),
                EventName = "York Sprint Triathlon",
                Discipline1Distance = 400,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.Pool,
                Discipline2Distance = 17,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 7, 32),
                ActualSwimTime = new TimeSpan(0, 7, 25),
                T1Time = new TimeSpan(0, 1, 23),
                Discipline2Time = new TimeSpan(0, 36, 4),
                T2Time = new TimeSpan(0, 0, 52),
                Discipline3Time = new TimeSpan(0, 22, 18),
                TotalTime = new TimeSpan(1, 8, 9),
                Discipline2AvgBikeSpeedMph = 17.5,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 6, 54),
                TotalParticipants = 335,
                OverallPosition = 47,
                Weather = WeatherType.Cloudy,
                WeatherNotes = "18°C, Cloudy, 9mph wind",
                EventNotes = "Nice pool. Pleased with the swim considering I've only swam twice in the last year! Kept it relaxed, breathing felt good. We had to swap lanes every 4 laps, so not ideal for a quick time.<br/>" +
                             "Bike course was really tight and technical (6 laps of the uni-campus). Wasn't the kind of course I'm used to so found it challenging, but good fun :)<br/>" +
                             "Run was 4 laps round the cycle track. Felt OK, but think capable of going a bit quicker. Enjoyed the race, would do it again.",
                Expanded = false
            };
            result7226965095.AddEventFigure("Tight, technical bike course.");
            eventResults.Add(result7226965095);

            // Hatfield Sprint Triathlon, 23/06/19.
            // 3774902533.

            return eventResults;
        }
    }
}

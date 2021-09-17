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

            // Hatfield Sprint Triathlon, 23/06/19.
            // 3774902533.


            // York Sprint Triathlon, 01/08/21.
            // 7226965095


            // Bassetlaw Sprint Triathlon, 05/09/21.
            var result7430411827 = new MultisportEventResult
            {
                Id = 7430411827,
                GarminId = 7430411827,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2021, 9, 5),
                EventName = "Bassetlaw Sprint Triathlon",
                Discipline1Distance = "400m Pool",
                Discipline2Distance = "25km",
                Discipline3Distance = "5km",
                Discipline1Time = new TimeSpan(0, 8, 1),
                T1Time = new TimeSpan(0, 1, 32),
                Discipline2Time = new TimeSpan(0, 43, 6),
                T2Time = new TimeSpan(0, 0, 55),
                Discipline3Time = new TimeSpan(0, 21, 8),
                TotalTime = new TimeSpan(1, 14, 44),
                Discipline1PaceSpeed = SwimHelper.Get25MetreSwimPace(400, new TimeSpan(0, 7, 22)),
                Discipline2PaceSpeed = "20.2 mph",
                Discipline3PaceSpeed = "6:53 min/mi",
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
            var result7430411827Figures = new List<string>();
            result7430411827Figures.Add("Swim time includes run to transition. 400m swim was 07:22.");
            result7430411827.EventFigures = result7430411827Figures;
            eventResults.Add(result7430411827);

            return eventResults;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Local
{
    public class LocalDuathlonService : IDuathlonService
    {
        public async Task<IEnumerable<MultisportEventResult>> GetResultsAsync()
        {
            var eventResults = new List<MultisportEventResult>();

            var result3487254095 = new MultisportEventResult
            {
                Id = 3487254095,
                GarminId = 3487254095,
                Sport = SportType.Duathlon,
                EventDate = new DateTime(2019, 3, 23),
                Course = Course.ClumberSprintDuathlon,
                Discipline1Distance = 5,
                Discipline1DistanceUnit = DistanceUnit.Kilometres,
                Discipline2Distance = 20,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 2.5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 20, 21),
                T1Time = new TimeSpan(0, 1, 38),
                Discipline2Time = new TimeSpan(0, 36, 29),
                T2Time = new TimeSpan(0, 1, 9),
                Discipline3Time = new TimeSpan(0, 10, 15),
                TotalTime = new TimeSpan(1, 9, 55),
                Discipline1AvgRunPaceMinMi = new TimeSpan(0, 6, 43),
                Discipline2AvgBikeSpeedMph = 19.4,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 2),
                TotalParticipants = 251,
                Discipline1Position = 43,
                T1Position = 67,
                Discipline2Position = 53,
                T2Position = 65,
                Discipline3Position = 45,
                OverallPosition = 55,
                Weather = WeatherType.SunnyCloudy,
                TemperatureDegreesCelsius = 9,
                WindMph = 12,
                EventNotes = "Good weather, enjoyed it again this year. Pleased to knock almost a minute off from last year.<br/>" +
                             "Felt really good on the first run. Went slightly easier on the bike than last year to save my legs for the second run. Think there's still room for improvement on the bike though; hoping to take some time off the bike leg next year.<br/>" +
                             "Second run was way better than last year (better pacing on the bike and better strength endurance from the gym work).<br/>" +
                             "Transitions still need some work!",
                CompareWithEventId = 2674814887
            };
            eventResults.Add(result3487254095);

            var result2674814887 = new MultisportEventResult
            {
                Id = 2674814887,
                GarminId = 2674814887,
                Sport = SportType.Duathlon,
                EventDate = new DateTime(2018, 5, 5),
                Course = Course.ClumberSprintDuathlon,
                Discipline1Distance = 5,
                Discipline1DistanceUnit = DistanceUnit.Kilometres,
                Discipline2Distance = 20,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 2.5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 20, 34),
                T1Time = new TimeSpan(0, 1, 36),
                Discipline2Time = new TimeSpan(0, 35, 46),
                T2Time = new TimeSpan(0, 0, 59),
                Discipline3Time = new TimeSpan(0, 11, 47),
                TotalTime = new TimeSpan(1, 10, 42),
                Discipline1AvgRunPaceMinMi = new TimeSpan(0, 6, 44),
                Discipline2AvgBikeSpeedMph = 19.8,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 26),
                TotalParticipants = 324,
                Discipline1Position = 99,
                T1Position = 147,
                Discipline2Position = 107,
                T2Position = 140,
                Discipline3Position = 127,
                OverallPosition = 103,
                Weather = WeatherType.Sunny,
                TemperatureDegreesCelsius = 15,
                WindMph = 6,
                EventNotes = "Notes: Good course, enjoyed the race. It was tough in the heat though.<br/>" +
                             "The first run was steady enough, although a bit more undulating than I expected.<br/>" +
                             "The bike leg went well; feeling stronger on the bike after all the winter turbo.<br/>" +
                             "The second run was tough going! More bike -> run brick workouts needed. Definitely want to give this a go again next year."
            };
            result2674814887.AddEventFigure("ITU World Championship Qualifier - strong field.");
            eventResults.Add(result2674814887);

            return eventResults;
        }
    }
}

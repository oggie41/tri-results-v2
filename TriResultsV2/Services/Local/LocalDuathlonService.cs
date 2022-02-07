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
        public Task<IEnumerable<MultisportEventResult>> GetResultsAsync()
        {
            var eventResults = new List<MultisportEventResult>();

            var result = new MultisportEventResult
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
                Discipline1Time = new TimeSpan(0, 20, 18),
                T1Time = new TimeSpan(0, 1, 38),
                Discipline2Time = new TimeSpan(0, 36, 30),
                T2Time = new TimeSpan(0, 1, 10),
                Discipline3Time = new TimeSpan(0, 10, 19),
                TotalTime = new TimeSpan(1, 9, 55),
                Discipline1AvgRunPaceMinMi = new TimeSpan(0, 6, 43),
                AvgBikeSpeedMph = 19.4,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 2),
                TotalParticipants = 253,
                Discipline1Position = 43,
                T1Position = 66,
                Discipline2Position = 53,
                T2Position = 65,
                Discipline3Position = 45,
                OverallPosition = 55,
                Weather = WeatherType.SunnyCloudy,
                TemperatureDegreesCelsius = 9,
                WindMph = 12,
                OfficialResultsUrl = "https://www.resultsbase.net/event/4649/results?round=10657",
                EventNotes = "Good weather, enjoyed it again this year. Pleased to knock almost a minute off from last year.<br/>" +
                             "Felt really good on the first run. Went slightly easier on the bike than last year to save my legs for the second run. Think there's still room for improvement on the bike though; hoping to take some time off the bike leg next year.<br/>" +
                             "Second run was way better than last year (better pacing on the bike and better strength endurance from the gym work).<br/>" +
                             "Transitions still need some work!",
                CompareWithEventId = 2674814887
            };
            eventResults.Add(result);

            result = new MultisportEventResult
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
                AvgBikeSpeedMph = 19.8,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 26),
                TotalParticipants = 325,
                Discipline1Position = 92,
                T1Position = 110,
                Discipline2Position = 98,
                T2Position = 113,
                Discipline3Position = 108,
                OverallPosition = 104,
                Weather = WeatherType.Sunny,
                TemperatureDegreesCelsius = 15,
                WindMph = 6,
                OfficialResultsUrl = "https://resultsbase.net/event/4146/results?round=9195",
                EventNotes = "Good course, enjoyed the race. It was tough in the heat though.<br/>" +
                             "The first run was steady enough, although a bit more undulating than I expected.<br/>" +
                             "The bike leg went well; feeling stronger on the bike after all the winter turbo.<br/>" +
                             "The second run was tough going! More bike -> run brick workouts needed. Definitely want to give this a go again next year."
            };
            result.AddEventFigure("ITU World Championship Qualifier - strong field.");
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 1612747638,
                GarminId = 1612747638,
                Sport = SportType.Duathlon,
                EventDate = new DateTime(2017, 3, 5),
                Course = Course.OultonParkStandardDuathlon,
                EventName = "Oulton Park Spring Duathlon",
                Discipline1Distance = 8.6,
                Discipline1DistanceUnit = DistanceUnit.Kilometres,
                Discipline2Distance = 38.8,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 4.3,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 38, 10),
                T1Time = new TimeSpan(0, 1, 17),
                Discipline2Time = new TimeSpan(1, 15, 56),
                T2Time = new TimeSpan(0, 1, 25),
                Discipline3Time = new TimeSpan(0, 20, 54),
                TotalTime = new TimeSpan(2, 17, 44),
                Discipline1AvgRunPaceMinMi = new TimeSpan(0, 7, 9),
                AvgBikeSpeedMph = 19.0,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 50),
                TotalParticipants = 225,
                Discipline1Position = 149,
                T1Position = 73,
                Discipline2Position = 165,
                T2Position = 71,
                Discipline3Position = 158,
                OverallPosition = 156,
                Weather = WeatherType.Rainy,
                TemperatureDegreesCelsius = 4,
                WindMph = 12,
                OfficialResultsUrl = "https://www.stuweb.co.uk/race/1si/",
                EventNotes = "First standard distance duathlon completed. Really tough race with the conditions.<br/>" +
                 "First run went well. Bad calf cramps on the bike, but managed to keep going; run -> bike brick sessions needed to help with this.<br/>" +
                 "Like a muppet forgot to take my helmet off in T2, so had to run with it! Second run was really tough - couldn't feel my feet!"
            };
            result.AddEventFigure("ITU World Championship Qualifier - strong field.");
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 930444954,
                GarminId = 930444954,
                Sport = SportType.Duathlon,
                EventDate = new DateTime(2015, 10, 17),
                Course = Course.ClumberOffRoadSprintDuathlon,
                Discipline1Distance = 5,
                Discipline1DistanceUnit = DistanceUnit.Kilometres,
                Discipline2Distance = 17,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 3,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 20, 55),
                T1Time = new TimeSpan(0, 0, 44),
                Discipline2Time = new TimeSpan(0, 55, 8),
                T2Time = new TimeSpan(0, 0, 41),
                Discipline3Time = new TimeSpan(0, 14, 32),
                TotalTime = new TimeSpan(1, 32, 0),
                Discipline1AvgRunPaceMinMi = new TimeSpan(0, 6, 58),
                AvgBikeSpeedMph = 11.5,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 45),
                TotalParticipants = 204,
                Discipline1Position = 69,
                T1Position = 41,
                Discipline2Position = 122,
                T2Position = 68,
                Discipline3Position = 79,
                OverallPosition = 93,
                Weather = WeatherType.Cloudy,
                TemperatureDegreesCelsius = 9,
                WindMph = 8,
                OfficialResultsUrl = "https://www.osbevents.com/results/", //http://dload.osb.s3.amazonaws.com/results/clumberoffroad15results.xls
                EventNotes = "Tough event. Felt good on the runs, but the cycle leg was really tough, especially on the hybrid (borrowed from Eddy)."
            };
            eventResults.Add(result);

            return Task.FromResult(eventResults.AsEnumerable());
        }
    }
}

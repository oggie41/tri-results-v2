using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Services.Local
{
    public class LocalRunService : IRunService
    {
        public async Task<IEnumerable<EventResult>> Get5KResultsAsync()
        {
            var eventResults = new List<EventResult>();

            var runResult7508938026 = new EventResult
            {
                Id = 7508938026,
                GarminId = 7508938026,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2021, 9, 18),
                EventName = "Rother Valley Parkrun",
                Course = Course.ParkrunRotherValley,
                TotalTime = new TimeSpan(0, 19, 14),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 8)
            };
            eventResults.Add(runResult7508938026);

            var runResult6659244437 = new EventResult
            {
                Id = 6659244437,
                GarminId = 6659244437,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2021, 4, 23),
                EventName = "York 5K Series Apr 2021",
                Course = Course.York5K,
                TotalTime = new TimeSpan(0, 18, 56),
                AvgRunPaceMinMi = new TimeSpan(0, 5, 58),
                PersonalBest = true
            };
            eventResults.Add(runResult6659244437);

            var runResult4143836736 = new EventResult
            {
                Id = 4143836736,
                GarminId = 4143836736,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 10, 10),
                EventName = "York 5K Series Oct 2019",
                Course = Course.York5K,
                TotalTime = new TimeSpan(0, 19, 32),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 7)
            };
            eventResults.Add(runResult4143836736);

            var runResult4006358867 = new EventResult
            {
                Id = 4006358867,
                GarminId = 4006358867,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 8, 30),
                EventName = "Loxley Lash 5K Series Aug 2019",
                Course = Course.LoxleyLash5K,
                TotalTime = new TimeSpan(0, 19, 31),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 6)
            };
            eventResults.Add(runResult4006358867);

            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> Get10KResultsAsync()
        {
            var eventResults = new List<EventResult>();

            var runResult4479290181 = new EventResult
            {
                Id = 4479290181,
                GarminId = 4479290181,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2020, 1, 26),
                EventName = "Clumber Park Trust10 Jan 2020",
                Course = Course.Trust10Clumber,
                TotalTime = new TimeSpan(0, 42, 33),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 51)
            };
            eventResults.Add(runResult4479290181);

            var runResult4300278601 = new EventResult
            {
                Id = 4300278601,
                GarminId = 4300278601,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 12, 1),
                EventName = "Percy Pud 10K 2019",
                Course = Course.PercyPud10K,
                TotalTime = new TimeSpan(0, 40, 49),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 35)
            };
            eventResults.Add(runResult4300278601);

            var runResult3914124969 = new EventResult
            {
                Id = 3914124969,
                GarminId = 3914124969,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 8, 4),
                EventName = "York 10K 2019",
                Course = Course.York10K,
                TotalTime = new TimeSpan(0, 42, 19),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 50)
            };
            eventResults.Add(runResult3914124969);

            var runResult2363409845 = new EventResult
            {
                Id = 2363409845,
                GarminId = 2363409845,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2017, 12, 3),
                EventName = "Percy Pud 10K 2017",
                Course = Course.PercyPud10K,
                TotalTime = new TimeSpan(0, 40, 46),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 33),
                PersonalBest = true
            };
            eventResults.Add(runResult2363409845);

            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> GetHalfMarathonResultsAsync()
        {
            var eventResults = new List<EventResult>();

            var runResult4196775224 = new EventResult
            {
                Id = 4196775224,
                GarminId = 4196775224,
                Sport = SportType.Run,
                Distance = 13.1,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2019, 10, 27),
                EventName = "Worksop Half Marathon 2019",
                Course = Course.WorksopHalfMarathon,
                TotalTime = new TimeSpan(1, 37, 37),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 27)
            };
            eventResults.Add(runResult4196775224);

            var runResult2434639248 = new EventResult
            {
                Id = 2434639248,
                GarminId = 2434639248,
                Sport = SportType.Run,
                Distance = 13.1,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2018, 1, 14),
                EventName = "Brass Monkey Half Marathon 2018",
                Course = Course.BrassMonkeyHalfMarathon,
                TotalTime = new TimeSpan(1, 35, 45),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 18),
                PersonalBest = true
            };
            eventResults.Add(runResult2434639248);

            var runResult1733241081 = new EventResult
            {
                Id = 1733241081,
                GarminId = 1733241081,
                Sport = SportType.Run,
                Distance = 13.1,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2017, 5, 14),
                EventName = "Leeds Half Marathon 2017",
                Course = Course.LeedsHalfMarathon,
                TotalTime = new TimeSpan(1, 39, 45),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 36)
            };
            eventResults.Add(runResult1733241081);

            return eventResults;
        }

        public async Task<IEnumerable<EventResult>> GetMultiStageResultsAsync()
        {
            var eventResults = new List<EventResult>();

            var runResult7028862720 = new EventResult
            {
                Id = 7028862720,
                GarminId = 7028862720,
                Sport = SportType.Run,
                EventType = EventType.MultiStage,
                Distance = 20,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2021, 6, 27),
                EventName = "Round Sheffield Run 2021",
                Course = Course.RoundSheffieldRun,
                TotalTime = new TimeSpan(1, 23, 49),
                TotalParticipants = 2161,
                OverallPosition = 126
            };
            eventResults.Add(runResult7028862720);

            return eventResults;
        }
    }
}

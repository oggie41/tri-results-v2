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
        public Task<IEnumerable<EventResult>> Get5KResultsAsync()
        {
            var eventResults = new List<EventResult>();

            EventResult result;

            result = new EventResult
            {
                Id = 7508938026,
                GarminId = 7508938026,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2021, 9, 18),
                Course = Course.ParkrunRotherValley,
                TotalTime = new TimeSpan(0, 19, 14),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 8),
                OfficialResultsUrl = "https://www.parkrun.org.uk/rothervalley/results/314/"
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 6659244437,
                GarminId = 6659244437,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2021, 4, 23),
                Course = Course.York5K,
                TotalTime = new TimeSpan(0, 18, 56),
                AvgRunPaceMinMi = new TimeSpan(0, 5, 58)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 4143836736,
                GarminId = 4143836736,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 10, 10),
                Course = Course.York5K,
                TotalTime = new TimeSpan(0, 19, 32),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 7)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 4006358867,
                GarminId = 4006358867,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 8, 30),
                Course = Course.LoxleyLash5K,
                TotalTime = new TimeSpan(0, 19, 31),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 6)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 3839734035,
                GarminId = 3839734035,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 7, 13),
                Course = Course.ParkrunRotherValley,
                TotalTime = new TimeSpan(0, 19, 5),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 6)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 3832387822,
                GarminId = 3832387822,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 7, 10),
                Course = Course.Doncaster5K,
                TotalTime = new TimeSpan(0, 19, 16),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 13)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 3547156793,
                GarminId = 3547156793,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 4, 11),
                Course = Course.York5K,
                TotalTime = new TimeSpan(0, 19, 6),
                AvgRunPaceMinMi = new TimeSpan(0, 5, 58)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 3046253186,
                GarminId = 3046253186,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2018, 9, 26),
                Course = Course.Leeds5K,
                TotalTime = new TimeSpan(0, 19, 16),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 2)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2936579865,
                GarminId = 2936579865,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2018, 8, 15),
                Course = Course.Leeds5K,
                TotalTime = new TimeSpan(0, 19, 54),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 14)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2722114296,
                GarminId = 2722114296,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2018, 5, 23),
                Course = Course.Leeds5K,
                TotalTime = new TimeSpan(0, 19, 25),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 2)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1851512710,
                GarminId = 1851512710,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2017, 7, 12),
                Course = Course.Doncaster5K,
                TotalTime = new TimeSpan(0, 19, 28),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 14)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1503295594,
                GarminId = 1503295594,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2016, 12, 31),
                Course = Course.ParkrunRotherValley,
                TotalTime = new TimeSpan(0, 19, 49),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 20)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 943047243,
                GarminId = 943047243,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2015, 10, 31),
                Course = Course.ParkrunRotherValley,
                TotalTime = new TimeSpan(0, 20, 14),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 27)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 525499963,
                GarminId = 525499963,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2014, 6, 21),
                Course = Course.ParkrunRotherValley,
                TotalTime = new TimeSpan(0, 20, 49),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 37)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 331411402,
                GarminId = 331411402,
                Sport = SportType.Run,
                Distance = 5,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2013, 6, 22),
                Course = Course.ParkrunRotherValley,
                TotalTime = new TimeSpan(0, 21, 57),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 1)
            };
            eventResults.Add(result);

            EventHelper.SetPersonalBest(eventResults);

            return Task.FromResult(eventResults.AsEnumerable());
        }

        public Task<IEnumerable<EventResult>> Get10KResultsAsync()
        {
            var eventResults = new List<EventResult>();

            EventResult result;

            result = new EventResult
            {
                Id = 7916749962,
                GarminId = 7916749962,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2021, 12, 5),
                Course = Course.PercyPud10K,
                TotalTime = new TimeSpan(0, 41, 8),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 37),
                OfficialResultsUrl = "https://results.sporthive.com/events/6873202899267092480/races/1"
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 7744477060,
                GarminId = 7744477060,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2021, 10, 31),
                Course = Course.Lincoln10K,
                TotalTime = new TimeSpan(0, 40, 43),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 36),
                OfficialResultsUrl = "https://www.chiptiming.co.uk/events/asda-foundation-lincoln-10k-2021/"
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 4479290181,
                GarminId = 4479290181,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2020, 1, 26),
                Course = Course.Trust10Clumber,
                TotalTime = new TimeSpan(0, 42, 33),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 51)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 4300278601,
                GarminId = 4300278601,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 12, 1),
                Course = Course.PercyPud10K,
                TotalTime = new TimeSpan(0, 40, 49),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 35)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 3914124969,
                GarminId = 3914124969,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 8, 4),
                Course = Course.York10K,
                TotalTime = new TimeSpan(0, 42, 19),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 50)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 3684717592,
                GarminId = 3684717592,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2019, 5, 26),
                Course = Course.Trust10Clumber,
                TotalTime = new TimeSpan(0, 42, 29),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 53)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 3185463773,
                GarminId = 3185463773,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2018, 11, 25),
                Course = Course.Trust10Clumber,
                TotalTime = new TimeSpan(0, 41, 43),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 43)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 3137698823,
                GarminId = 3137698823,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2018, 11, 4),
                Course = Course.LeedsAbbeyDash10K,
                TotalTime = new TimeSpan(0, 42, 31),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 46)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2363409845,
                GarminId = 2363409845,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2017, 12, 3),
                Course = Course.PercyPud10K,
                TotalTime = new TimeSpan(0, 40, 46),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 33)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2295342647,
                GarminId = 2295342647,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2017, 11, 5),
                Course = Course.LeedsAbbeyDash10K,
                TotalTime = new TimeSpan(0, 41, 57),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 42)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1899660762,
                GarminId = 1899660762,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2017, 8, 6),
                Course = Course.York10K,
                TotalTime = new TimeSpan(0, 41, 21),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 40)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1537055044,
                GarminId = 1537055044,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2017, 1, 22),
                Course = Course.Trust10Clumber,
                TotalTime = new TimeSpan(0, 42, 28),
                AvgRunPaceMinMi = new TimeSpan(0, 6, 49)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1472527041,
                GarminId = 1472527041,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2016, 12, 4),
                Course = Course.PercyPud10K,
                TotalTime = new TimeSpan(0, 43, 58),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 5)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 958129264,
                GarminId = 958129264,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2015, 11, 15),
                Course = Course.LeedsAbbeyDash10K,
                TotalTime = new TimeSpan(0, 44, 48),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 8)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 561580839,
                GarminId = 561580839,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2014, 8, 10),
                Course = Course.SherwoodPinesTrail10K,
                TotalTime = new TimeSpan(0, 44, 19),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 14)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 492623126,
                GarminId = 492623126,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2014, 5, 4),
                Course = Course.Chatsworth10K,
                TotalTime = new TimeSpan(0, 46, 16),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 35)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 382974225,
                GarminId = 382974225,
                Sport = SportType.Run,
                Distance = 10,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2013, 9, 29),
                EventName = "BUPA Great Yorkshire 10K 2013",
                Course = Course.Sheffield10KHillsborough,
                TotalTime = new TimeSpan(0, 47, 21),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 36)
            };
            eventResults.Add(result);

            EventHelper.SetPersonalBest(eventResults);

            return Task.FromResult(eventResults.AsEnumerable());
        }

        public Task<IEnumerable<EventResult>> GetHalfMarathonResultsAsync()
        {
            var eventResults = new List<EventResult>();

            EventResult result;

            result = new EventResult
            {
                Id = 4196775224,
                GarminId = 4196775224,
                Sport = SportType.Run,
                Distance = 13.1,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2019, 10, 27),
                Course = Course.WorksopHalfMarathon,
                TotalTime = new TimeSpan(1, 37, 37),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 27)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 2434639248,
                GarminId = 2434639248,
                Sport = SportType.Run,
                Distance = 13.1,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2018, 1, 14),
                Course = Course.BrassMonkeyHalfMarathon,
                TotalTime = new TimeSpan(1, 35, 45),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 18)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 1733241081,
                GarminId = 1733241081,
                Sport = SportType.Run,
                Distance = 13.1,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2017, 5, 14),
                Course = Course.LeedsHalfMarathon,
                TotalTime = new TimeSpan(1, 39, 45),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 36)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 531159210,
                GarminId = 531159210,
                Sport = SportType.Run,
                Distance = 13.1,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2014, 6, 29),
                Course = Course.HumberBridgeHalfMarathon,
                TotalTime = new TimeSpan(1, 43, 0),
                AvgRunPaceMinMi = new TimeSpan(0, 7, 54)
            };
            eventResults.Add(result);

            result = new EventResult
            {
                Id = 311547876,
                GarminId = 311547876,
                Sport = SportType.Run,
                Distance = 13.1,
                DistanceUnit = DistanceUnit.Miles,
                EventDate = new DateTime(2013, 5, 12),
                EventName = "Sheffield Half Marathon 2013",
                Course = Course.SheffieldHalfMarathonDonValley,
                TotalTime = new TimeSpan(1, 48, 6),
                AvgRunPaceMinMi = new TimeSpan(0, 8, 15)
            };
            eventResults.Add(result);

            EventHelper.SetPersonalBest(eventResults);

            return Task.FromResult(eventResults.AsEnumerable());
        }

        public Task<IEnumerable<EventResult>> GetMultiStageResultsAsync()
        {
            var eventResults = new List<EventResult>();

            EventResult result;

            result = new EventResult
            {
                Id = 7028862720,
                GarminId = 7028862720,
                Sport = SportType.Run,
                EventType = EventType.MultiStage,
                Distance = 20,
                DistanceUnit = DistanceUnit.Kilometres,
                EventDate = new DateTime(2021, 6, 27),
                Course = Course.RoundSheffieldRun,
                TotalTime = new TimeSpan(1, 23, 49),
                TotalParticipants = 2161,
                OverallPosition = 126,
                OfficialResultsUrl = "https://www.sportident.co.uk/results/Kandoo/2021/RSR/"
            };
            eventResults.Add(result);

            return Task.FromResult(eventResults.AsEnumerable());
        }
    }
}

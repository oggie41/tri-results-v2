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
                Course = Course.BassetlawSprintTriathlon,
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
                TemperatureDegreesCelsius = 18,
                WindMph = 5,
                EventNotes = "Great conditions. Swim went pretty well considering the lack of swim training.<br/>" +
                             "Good bike course, plenty of opportunity to get on the tri bars. Need to up the bike training really though, especially TT specific riding, didn't feel strong enough at times.<br/>" +
                             "Run was 2 laps around the local area. Felt pretty good and finished strongly. With more bike training should be able to perform better on the run as will feel fresher.<br/>" +
                             "Really enjoyed the race, definitely want to do it again next year."
            };
            eventResults.Add(result7430411827);

            var result7226965095 = new MultisportEventResult
            {
                Id = 7226965095,
                GarminId = 7226965095,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2021, 8, 1),
                Course = Course.YorkSprintTriathlon,
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
                TemperatureDegreesCelsius = 18,
                WindMph = 9,
                EventNotes = "First time doing this race. Pleased with the swim considering I've only swam twice in the last year! Kept it relaxed, breathing felt good. We had to swap lanes every 4 laps, so not ideal for a quick time.<br/>" +
                             "Bike course was really tight and technical (6 laps of the uni-campus). Wasn't the kind of course I'm used to so found it challenging, but good fun :)<br/>" +
                             "Run was 4 laps round the cycle track. Felt OK, but think capable of going a bit quicker. Enjoyed the race, would do it again.",
                Expanded = false
            };
            result7226965095.AddEventFigure("Tight, technical bike course.", NamedIcon.Bike);
            eventResults.Add(result7226965095);

            var result3774902533 = new MultisportEventResult
            {
                Id = 3774902533,
                GarminId = 3774902533,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2019, 6, 23),
                Course = Course.HatfieldSprintTriathlon,
                Discipline1Distance = 750,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.OW,
                Discipline2Distance = 23.5,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 12, 52),
                T1Time = new TimeSpan(0, 1, 10),
                Discipline2Time = new TimeSpan(0, 41, 58),
                T2Time = new TimeSpan(0, 0, 35),
                Discipline3Time = new TimeSpan(0, 20, 17),
                TotalTime = new TimeSpan(1, 16, 52),
                Discipline2AvgBikeSpeedMph = 21.3,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 6, 49),
                TotalParticipants = 55,
                Discipline1Position = 11,
                T1Position = 24,
                Discipline2Position = 17,
                T2Position = 17,
                Discipline3Position = 13,
                OverallPosition = 14,
                Weather = WeatherType.Sunny,
                TemperatureDegreesCelsius = 14,
                WindMph = 5,
                EventNotes = "Early start! Ideal conditions when we got started. Frustrating swim - got trapped in a pack for first 2/3 of the swim; made decent progress after last buoy and finished strongly though. Need to position better next OWS race so can pass on the outside. Polarized lenses would be better for next time as well - was difficult sighting with the sun today at times.<br/>" +
                             "Really enjoyed the bike leg - felt fresh after the swim, not much wind, flat roads, so was a quick one. Still loving the ISM saddle in TT position. Still think there's room for improvement on the bike though. Legs felt absolutely fine, but cramped in calf muscles after changing shoes in T2.<br/>" +
                             "Took first mile of the run to shake off the cramps, but felt good after that. Pleased with performance overall :)",
                CompareWithEventId = 1260511684
            };
            eventResults.Add(result3774902533);

            var result1260511684 = new MultisportEventResult
            {
                Id = 1260511684,
                GarminId = 1260511684,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2016, 7, 17),
                Course = Course.HatfieldSprintTriathlon,
                Discipline1Distance = 750,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.OW,
                Discipline2Distance = 23.5,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 12, 34),
                T1Time = new TimeSpan(0, 1, 50),
                Discipline2Time = new TimeSpan(0, 47, 1),
                T2Time = new TimeSpan(0, 0, 44),
                Discipline3Time = new TimeSpan(0, 23, 14),
                TotalTime = new TimeSpan(1, 25, 21),
                Discipline2AvgBikeSpeedMph = 18.6,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 27),
                TotalParticipants = 61,
                Discipline1Position = 22,
                T1Position = 47,
                Discipline2Position = 27,
                T2Position = 33,
                Discipline3Position = 24,
                OverallPosition = 25,
                Weather = WeatherType.Sunny,
                TemperatureDegreesCelsius = 18,
                WindMph = 7,
                EventNotes = "Enjoyed the race. Open water swim went well (750m is the furthest I've done so far), started nearer the front as well.<br/>" +
                             "Felt stronger on the bike. Once again, the run was OK, but should be doing quicker."
            };
            eventResults.Add(result1260511684);

            return eventResults;
        }
    }
}

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
        public Task<IEnumerable<MultisportEventResult>> GetResultsAsync()
        {
            var eventResults = new List<MultisportEventResult>();

            var result = new MultisportEventResult
            {
                Id = 7430411827,
                GarminId = 7430411827,
                IntervalsIcuId = 1879038,
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
                AvgBikeSpeedMph = 20.2,
                AvgBikePower = 209,
                NormalizedBikePower = 217,
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
                OfficialResultsUrl = "https://results.racetimingsolutions.co.uk/Results.aspx?CId=16269&RId=1269&EId=1",
                EventNotes = "Great conditions. Swim went pretty well considering the lack of swim training.<br/>" +
                             "Good bike course, plenty of opportunity to get on the tri bars. Need to up the bike training really though, especially TT specific riding, didn't feel strong enough at times.<br/>" +
                             "Run was 2 laps around the local area. Felt pretty good and finished strongly. With more bike training should be able to perform better on the run as will feel fresher.<br/>" +
                             "Really enjoyed the race, definitely want to do it again next year."
            };
            eventResults.Add(result);

            result = new MultisportEventResult
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
                AvgBikeSpeedMph = 17.5,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 6, 54),
                TotalParticipants = 335,
                OverallPosition = 47,
                Weather = WeatherType.Cloudy,
                TemperatureDegreesCelsius = 18,
                WindMph = 9,
                EventNotes = "First time doing this race. Pleased with the swim considering I've only swam twice in the last year! Kept it relaxed, breathing felt good. We had to swap lanes every 4 laps, so not ideal for a quick time.<br/>" +
                             "Bike course was really tight and technical (6 laps of the uni-campus). Wasn't the kind of course I'm used to so found it challenging, but good fun :)<br/>" +
                             "Run was 4 laps round the cycle track. Felt OK, but think capable of going a bit quicker. Enjoyed the race, would do it again."
            };
            result.AddEventFigure("Tight, technical bike course.", NamedIcon.Bike);
            eventResults.Add(result);

            result = new MultisportEventResult
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
                AvgBikeSpeedMph = 21.3,
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
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 3575876082,
                GarminId = 3575876082,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2019, 4, 21),
                Course = Course.EpworthSprintTriathlon,
                EventName = "Epworth Start of Season Sprint Triathlon",
                Discipline1Distance = 400,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.Pool,
                Discipline2Distance = 20,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 7, 13),
                ActualSwimTime = new TimeSpan(0, 6, 53),
                T1Time = new TimeSpan(0, 0, 52),
                Discipline2Time = new TimeSpan(0, 36, 51),
                T2Time = new TimeSpan(0, 0, 47),
                Discipline3Time = new TimeSpan(0, 19, 22),
                TotalTime = new TimeSpan(1, 5, 5),
                AvgBikeSpeedMph = 20.0,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 6, 47),
                TotalParticipants = 81,
                Discipline1Position = 19,
                T1Position = 17,
                Discipline2Position = 21,
                T2Position = 15,
                Discipline3Position = 10,
                OverallPosition = 12,
                Weather = WeatherType.Sunny,
                TemperatureDegreesCelsius = 10,
                WindMph = 2,
                EventNotes = "Epworth PB and highest finish so far :) Perfect conditions -  sunny, not too hot and not much wind.<br/>" +
                             "Quickest Epworth swim - decent chunk off last time. Most comfortable I've felt in a triathlon pool swim, the video lesson from Nov has paid off.<br/>" +
                             "Bike leg went well, felt controlled and left enough in the tank for the run. Loving the new ISM saddle for TT position. Have definitely still got room for improvement on the bike, although would need to up my bike volume.<br/>" +
                             "The run went really well. Felt strong, the strength workouts have started to pay off for the later stages in races.",
                CompareWithEventId = 3036668531
            };
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 3036668531,
                GarminId = 3036668531,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2018, 9, 23),
                Course = Course.EpworthSprintTriathlon,
                EventName = "Epworth End of Season Sprint Triathlon",
                Discipline1Distance = 400,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.Pool,
                Discipline2Distance = 20,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 7, 50),
                T1Time = new TimeSpan(0, 1, 15),
                Discipline2Time = new TimeSpan(0, 36, 48),
                T2Time = new TimeSpan(0, 0, 56),
                Discipline3Time = new TimeSpan(0, 20, 10),
                TotalTime = new TimeSpan(1, 6, 56),
                AvgBikeSpeedMph = 20.0,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 6, 54),
                TotalParticipants = 88,
                Discipline1Position = 22,
                T1Position = 31,
                Discipline2Position = 18,
                T2Position = 32,
                Discipline3Position = 12,
                OverallPosition = 15,
                Weather = WeatherType.SunnyCloudy,
                TemperatureDegreesCelsius = 9,
                WindMph = 6,
                EventNotes = "Best finish so far :) Quickest Epworth swim - first 10 laps were difficult with congested lane and leaking goggles, but finished strongly last 10 laps.<br/>" +
                 "Felt good on the bike, decent improvement. Best tri run so far - felt strong, recent brick workouts paid off.<br/>" +
                 "Transitions need some work!",
                CompareWithEventId = 1681338479
            };
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 2966291134,
                GarminId = 2966291134,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2018, 8, 27),
                Course = Course.MatlockSprintTriathlon,
                Discipline1Distance = 400,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.Pool,
                Discipline2Distance = 17,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5.1,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 7, 43),
                ActualSwimTime = new TimeSpan(0, 7, 43),
                Discipline2Time = new TimeSpan(0, 34, 5),
                Discipline3Time = new TimeSpan(0, 25, 8),
                TotalTime = new TimeSpan(1, 10, 3),
                AvgBikeSpeedMph = 17.4,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 49),
                TotalParticipants = 151,
                Discipline1Position = 48,
                OverallPosition = 30,
                Weather = WeatherType.Cloudy,
                TemperatureDegreesCelsius = 14,
                WindMph = 13,
                EventNotes = "Nice chilled atmosphere, as always. Paced the swim more conservatively than previous races as wanted to concentrate on keeping the breathing relaxed. The swim split was slightly slower than last year, but felt much more controlled.<br/>" +
                             "Tough bike and run legs - did as well as I could on the day. Caught by some traffic riding back into Matlock, so that slowed the ride by around 20 secs.<br/>" +
                             "The lack of brick runs this year showed in the first couple of miles of the run though.<br/>" +
                             "Highest finish so far (inside top 20%).",
                CompareWithEventId = 1944167661
            };
            result.AddEventFigure("Transition and bike/run splits not provided (no chip timing) - bike/run improvement (against this race last year) not accurate.");
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 1944167661,
                GarminId = 1944167661,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2017, 8, 28),
                Course = Course.MatlockSprintTriathlon,
                Discipline1Distance = 400,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.Pool,
                Discipline2Distance = 17,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5.1,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 7, 18),
                ActualSwimTime = new TimeSpan(0, 7, 18),
                Discipline2Time = new TimeSpan(0, 34, 45),
                Discipline3Time = new TimeSpan(0, 25, 9),
                TotalTime = new TimeSpan(1, 9, 47),
                AvgBikeSpeedMph = 17.3,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 55),
                TotalParticipants = 144,
                Discipline1Position = 33,
                OverallPosition = 31,
                Weather = WeatherType.Sunny,
                TemperatureDegreesCelsius = 18,
                WindMph = 6,
                EventNotes = "Great value for money race (only a tenner) - relaxed atmosphere with no-one taking it too serious.<br/>" +
                             "Relatively pleased with swim time, although breathing got too quick after about 200m - need to work on this for race efforts.<br/>" +
                             "The bike and run legs are both really tough going with the climbing involved. I actually used the correct bike route this year, so that was a victory in itself!<br/>" +
                             "Highest finish so far (inside top 25%), so pleased with progress."
            };
            result.AddEventFigure("Transition times not provided (no chip timing).");
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 1834789890,
                GarminId = 1834789890,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2017, 7, 1),
                Course = Course.RiponStandardTriathlon,
                Discipline1Distance = 1500,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.OW,
                Discipline2Distance = 40,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 10,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 27, 40),
                T1Time = new TimeSpan(0, 2, 31),
                Discipline2Time = new TimeSpan(1, 15, 21),
                T2Time = new TimeSpan(0, 1, 16),
                Discipline3Time = new TimeSpan(0, 48, 52),
                TotalTime = new TimeSpan(2, 35, 40),
                AvgBikeSpeedMph = 19.8,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 52),
                TotalParticipants = 1014,
                Discipline1Position = 359,
                T1Position = 783,
                Discipline2Position = 553,
                T2Position = 420,
                Discipline3Position = 514,
                OverallPosition = 484,
                Weather = WeatherType.Sunny,
                TemperatureDegreesCelsius = 20,
                WindMph = 14,
                EventNotes = "Loved the race - great vibe and atmosphere, really well organised. First Olympic distance triathlon completed :)<br/>" +
                             "Open water swim went well, felt comfortable.<br/>" +
                             "Felt good on the bike - paced it much better than previous races; didn't wreck the legs too much.<br/>" +
                             "The run was pretty tough in the heat, but the legs felt pretty good (considering the distance).<br/>" +
                             "Pleased with overall performance. Want to try it again next year to aim for a sub 2hr 30mins."
            };
            result.AddEventFigure("ITU World Championship Qualifier - strong field.");
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 1681338479,
                GarminId = 1681338479,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2017, 4, 16),
                Course = Course.EpworthSprintTriathlon,
                EventName = "Epworth Start of Season Sprint Triathlon",
                Discipline1Distance = 400,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.Pool,
                Discipline2Distance = 20,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 7, 57),
                T1Time = new TimeSpan(0, 1, 14),
                Discipline2Time = new TimeSpan(0, 38, 20),
                T2Time = new TimeSpan(0, 0, 48),
                Discipline3Time = new TimeSpan(0, 20, 53),
                TotalTime = new TimeSpan(1, 9, 10),
                AvgBikeSpeedMph = 18.9,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 17),
                TotalParticipants = 119,
                Discipline1Position = 46,
                T1Position = 39,
                Discipline2Position = 36,
                T2Position = 25,
                Discipline3Position = 27,
                OverallPosition = 33,
                Weather = WeatherType.SunnyCloudy,
                TemperatureDegreesCelsius = 6,
                WindMph = 8,
                EventNotes = "Over 6 mins quicker than last year, plus best finish so far, so big improvement :)<br/>" +
                 "Steady enough swim; more CSS work should start to improve the time.<br/>" +
                 "Felt good on the bike, big improvement over last year. Slight calf cramp, but nothing major.<br/>" +
                 "Bad calf cramp at the start of the run, but it went away after the first mile; finished the run strongly.",
                CompareWithEventId = 1141389428
            };
            eventResults.Add(result);

            result = new MultisportEventResult
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
                AvgBikeSpeedMph = 18.6,
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
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 1200043624,
                GarminId = 1200043624,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2016, 6, 4),
                Course = Course.RotherValleySprintTriathlon,
                Discipline1Distance = 500,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.OW,
                Discipline2Distance = 25.4,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 10, 4),
                T1Time = new TimeSpan(0, 2, 20),
                Discipline2Time = new TimeSpan(0, 52, 46),
                T2Time = new TimeSpan(0, 0, 44),
                Discipline3Time = new TimeSpan(0, 22, 30),
                TotalTime = new TimeSpan(1, 28, 24),
                AvgBikeSpeedMph = 17.9,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 15),
                TotalParticipants = 74,
                Discipline1Position = 22,
                T1Position = 37,
                Discipline2Position = 31,
                T2Position = 32,
                Discipline3Position = 19,
                OverallPosition = 28,
                Weather = WeatherType.Cloudy,
                TemperatureDegreesCelsius = 14,
                WindMph = 8,
                EventNotes = "Really enjoyed this one. First open water swim completed; felt comfortable on the swim.<br/>" +
                             "Bike went well. Run OK, but can do quicker - more brick runs needed."
            };
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 1141389428,
                GarminId = 1141389428,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2016, 4, 24),
                Course = Course.EpworthSprintTriathlon,
                EventName = "Epworth Start of Season Sprint Triathlon",
                Discipline1Distance = 400,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.Pool,
                Discipline2Distance = 20,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 8, 7),
                T1Time = new TimeSpan(0, 1, 41),
                Discipline2Time = new TimeSpan(0, 42, 27),
                T2Time = new TimeSpan(0, 0, 48),
                Discipline3Time = new TimeSpan(0, 22, 43),
                TotalTime = new TimeSpan(1, 15, 44),
                AvgBikeSpeedMph = 17.0,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 52),
                TotalParticipants = 110,
                Discipline1Position = 46,
                T1Position = 51,
                Discipline2Position = 58,
                T2Position = 25,
                Discipline3Position = 47,
                OverallPosition = 52,
                Weather = WeatherType.Sunny,
                TemperatureDegreesCelsius = 6,
                WindMph = 14,
                EventNotes = "Not my finest race at all. Bad swim; went off too quick, goggles leaked.<br/>" +
                             "First time racing on road bike; improved since last time, but wasn't strong enough into the wind.<br/>" +
                             "Ran badly (over a minute slower than last time!), didn't push it enough.",
                CompareWithEventId = 890290409
            };
            eventResults.Add(result);

            result = new MultisportEventResult
            {
                Id = 890290409,
                GarminId = 890290409,
                Sport = SportType.Triathlon,
                EventDate = new DateTime(2015, 9, 6),
                Course = Course.EpworthSprintTriathlon,
                EventName = "Epworth End of Season Sprint Triathlon",
                Discipline1Distance = 400,
                Discipline1DistanceUnit = DistanceUnit.Metres,
                SwimType = SwimType.Pool,
                Discipline2Distance = 20,
                Discipline2DistanceUnit = DistanceUnit.Kilometres,
                Discipline3Distance = 5,
                Discipline3DistanceUnit = DistanceUnit.Kilometres,
                Discipline1Time = new TimeSpan(0, 8, 52),
                T1Time = new TimeSpan(0, 2, 44),
                Discipline2Time = new TimeSpan(0, 46, 24),
                T2Time = new TimeSpan(0, 0, 44),
                Discipline3Time = new TimeSpan(0, 21, 14),
                TotalTime = new TimeSpan(1, 19, 58),
                AvgBikeSpeedMph = 15.6,
                Discipline3AvgRunPaceMinMi = new TimeSpan(0, 7, 18),
                TotalParticipants = 109,
                Discipline1Position = 51,
                T1Position = 99,
                Discipline2Position = 87,
                T2Position = 22,
                Discipline3Position = 24,
                OverallPosition = 65,
                Weather = WeatherType.Sunny,
                TemperatureDegreesCelsius = 10,
                WindMph = 5,
                EventNotes = "First triathlon completed :) Really enjoyed it.<br/>" +
                             "Used Eddy's Dawes hybrid bike - definitely need a road bike!"
            };
            eventResults.Add(result);

            return Task.FromResult(eventResults.AsEnumerable());
        }
    }
}

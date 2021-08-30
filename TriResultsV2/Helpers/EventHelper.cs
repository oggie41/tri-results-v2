using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Helpers
{
    public enum SportType
    {
        Swim,
        Bike,
        Run,
        Triathlon,
        Duathlon
    }

    public enum WeatherType
    {
        Sunny,
        Cloudy,
        SunnyCloudy,
        Rainy,
    }

    public static class EventHelper
    {
        public const string Distance200Metres = "200m";
        public const string Distance400Metres = "400m";
        public const string Distance5Kilometres = "5K";
        public const string Distance10Kilometres = "10K";
        public const string Distance20Kilometres = "20K";
        public const string Distance10Miles = "10mi";
        public const string Distance25Miles = "25mi";
        public const string DistanceHalfMarathon = "HM";

        public static string GetTotalTimeFormatted(TimeSpan totalTime)
        {
            string totalTimeFormatted;

            if (totalTime.Hours > 0)
            {
                totalTimeFormatted = $"{totalTime.Hours}:{totalTime.Minutes:D2}:{totalTime.Seconds:D2}";
            }
            else
            {
                totalTimeFormatted = $"{totalTime.Minutes:D2}:{totalTime.Seconds:D2}";
            }

            return totalTimeFormatted;
        }
    }
}

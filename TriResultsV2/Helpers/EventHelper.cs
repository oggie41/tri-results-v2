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

        public static string GetFormattedTime(TimeSpan totalTime)
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

        private static string GetOrdinalSuffix(int number)
        {
            string numberStr = number.ToString();
            if (numberStr.EndsWith("11")) return "th";
            if (numberStr.EndsWith("12")) return "th";
            if (numberStr.EndsWith("13")) return "th";
            if (numberStr.EndsWith("1")) return "st";
            if (numberStr.EndsWith("2")) return "nd";
            if (numberStr.EndsWith("3")) return "rd";
            return "th";
        }

        public static string GetFormattedPosition(int? position)
        {
            string positionStr = "-";

            if (position.HasValue)
            {
                positionStr = $"{position}{GetOrdinalSuffix(position.Value)}";
            }

            return positionStr;
        }

        public static string GetPerformance(int? totalParticipants, int? position)
        {
            string performanceStr = "-";

            if (totalParticipants.HasValue && position.HasValue)
            {
                double performance = 101 - (((double)position.Value / (double)totalParticipants.Value) * 100);
                performanceStr = $"{Math.Round(performance, 0)}%";
            }

            return performanceStr;
        }

        public static string GetWeatherIconClass(WeatherType weather)
        {
            string weatherIconClass = "";

            if (weather == WeatherType.Sunny)
            {
                weatherIconClass = "fas fa-sun";
            }
            else if (weather == WeatherType.Cloudy)
            {
                weatherIconClass = "fas fa-cloud";
            }
            else if (weather == WeatherType.SunnyCloudy)
            {
                weatherIconClass = "fas fa-cloud-sun";
            }
            else if (weather == WeatherType.Rainy)
            {
                weatherIconClass = "fas fa-cloud-rain";
            }

            return weatherIconClass;
        }
    }
}

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

    public enum SwimType
    {
        Pool,
        OW
    }

    public enum EventType
    {
        Standard,
        MultiStage
    }

    public enum DistanceUnit
    {
        Metres,
        Kilometres,
        Miles
    }

    public enum WeatherType
    {
        Sunny,
        Cloudy,
        SunnyCloudy,
        Rainy
    }

    public static class EventHelper
    {
        public static string GetFormattedDistance(double distance, DistanceUnit distanceUnit, SportType sportType)
        {
            string distanceUnitStr = string.Empty;

            switch (distanceUnit)
            {
                case DistanceUnit.Metres:
                    distanceUnitStr = "m";
                    break;
                case DistanceUnit.Kilometres:
                    distanceUnitStr = "km";
                    break;
                case DistanceUnit.Miles:
                    distanceUnitStr = "mi";
                    break;
            }

            string distanceStr = $"{distance}{distanceUnitStr}";

            if (sportType == SportType.Run)
            {
                if (distance == 5 && distanceUnit == DistanceUnit.Kilometres)
                {
                    distanceStr = "5K";
                }
                else if (distance == 10 && distanceUnit == DistanceUnit.Kilometres)
                {
                    distanceStr = "10K";
                }
                else if (distance == 13.1 && distanceUnit == DistanceUnit.Miles)
                {
                    distanceStr = "HM";
                }
                else if (distance == 26.2 && distanceUnit == DistanceUnit.Miles)
                {
                    distanceStr = "MA";
                }
            }

            return distanceStr;
        }

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

        public static string GetImprovementHtml(TimeSpan time, TimeSpan timeToCompare)
        {
            string improvementSign = string.Empty;
            string improvementCssClass = string.Empty;
            double improvementInSeconds = time.TotalSeconds - timeToCompare.TotalSeconds;
            double improvementInSecondsAsPositive = improvementInSeconds;

            if (improvementInSeconds < 0)
            {
                improvementSign = "-";
                improvementCssClass = "text-success";
                improvementInSecondsAsPositive = improvementInSeconds * - 1;
            }
            else if (improvementInSeconds > 0)
            {
                improvementSign = "+";
                improvementCssClass = "text-danger";
            }

            var improvementTimeSpan = TimeSpan.FromSeconds(improvementInSecondsAsPositive);
            string improvementFormatted = $"<span class=\"{improvementCssClass}\">{improvementSign}{improvementTimeSpan.Minutes:D2}:{improvementTimeSpan.Seconds:D2}</span>";

            if (improvementInSeconds == 0)
            {
                improvementFormatted = "-";
            }

            return improvementFormatted;
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

            switch (weather)
            {
                case WeatherType.Sunny:
                    weatherIconClass = "fas fa-sun";
                    break;
                case WeatherType.Cloudy:
                    weatherIconClass = "fas fa-cloud";
                    break;
                case WeatherType.SunnyCloudy:
                    weatherIconClass = "fas fa-cloud-sun";
                    break;
                case WeatherType.Rainy:
                    weatherIconClass = "fas fa-cloud-rain";
                    break;
            }

            return weatherIconClass;
        }

        public static string GetFormattedWeatherNotes(WeatherType weather, int temperatureDegreesCelsius, int windMph)
        {
            string weatherNotes = $"{temperatureDegreesCelsius}°C, {weather}, {windMph}mph wind";
            return weatherNotes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;

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

    public enum Course
    {
        [Display(Name = "Bassetlaw Sprint Triathlon")]
        BassetlawSprintTriathlon,

        [Display(Name = "Brass Monkey Half Marathon")]
        BrassMonkeyHalfMarathon,

        [Display(Name = "Chatsworth 10K")]
        Chatsworth10K,

        [Display(Name = "Clumber Off-Road Sprint Duathlon")]
        ClumberOffRoadSprintDuathlon,

        [Display(Name = "Clumber Sprint Duathlon")]
        ClumberSprintDuathlon,

        [Display(Name = "Cuckney 10mi TT")]
        Cuckney10MileTT,

        [Display(Name = "Doncaster 5K")]
        Doncaster5K,

        [Display(Name = "Epworth Sprint Triathlon")]
        EpworthSprintTriathlon,

        [Display(Name = "Hatfield 25mi TT")]
        Hatfield25MileTT,

        [Display(Name = "Hatfield Sprint Triathlon")]
        HatfieldSprintTriathlon,

        [Display(Name = "Humber Bridge Half Marathon")]
        HumberBridgeHalfMarathon,

        [Display(Name = "Leeds 5K Series")]
        Leeds5K,

        [Display(Name = "Leeds Abbey Dash 10K")]
        LeedsAbbeyDash10K,
        
        [Display(Name = "Leeds Half Marathon")]
        LeedsHalfMarathon,

        [Display(Name = "Lincoln 10K")]
        Lincoln10K,

        [Display(Name = "Loxley Lash 5K Series")]
        LoxleyLash5K,

        [Display(Name = "Oulton Park Sprint Duathlon")]
        OultonParkSprintDuathlon,

        [Display(Name = "Oulton Park Standard Duathlon")]
        OultonParkStandardDuathlon,

        [Display(Name = "Parkrun (Clifton Park)")]
        ParkrunCliftonPark,
        
        [Display(Name = "Parkrun (Endcliffe)")]
        ParkrunEndcliffe,
        
        [Display(Name = "Parkrun (Rother Valley)")]
        ParkrunRotherValley,

        [Display(Name = "Percy Pud 10K")]
        PercyPud10K,

        [Display(Name = "Rother Valley 10K")]
        RotherValley10K,

        [Display(Name = "Rother Valley Sprint Triathlon")]
        RotherValleySprintTriathlon,

        [Display(Name = "Round Sheffield Run")]
        RoundSheffieldRun,

        [Display(Name = "Sheffield 10K")]
        Sheffield10K,

        [Display(Name = "Sheffield 10K (Hillsborough)")]
        Sheffield10KHillsborough,

        [Display(Name = "Sheffield Half Marathon")]
        SheffieldHalfMarathon,

        [Display(Name = "Sheffield Half Marathon (Don Valley)")]
        SheffieldHalfMarathonDonValley,

        [Display(Name = "Sherwood Pines 10K")]
        SherwoodPines10K,

        [Display(Name = "Sherwood Pines Trail 10K")]
        SherwoodPinesTrail10K,
        
        [Display(Name = "Trust10 (Clumber)")]
        Trust10Clumber,
        
        [Display(Name = "Trust10 (Longshaw)")]
        Trust10Longshaw,
        
        [Display(Name = "Westfield")]
        Westfield,

        [Display(Name = "Worksop Half Marathon")]
        WorksopHalfMarathon,
        
        [Display(Name = "York 5K Series")]
        York5K,
        
        [Display(Name = "York 10K")]
        York10K,

        [Display(Name = "York Sprint Triathlon")]
        YorkSprintTriathlon
    }

    public enum SwimType
    {
        [Display(Name = "Pool")]
        Pool,

        [Display(Name = "Open Water")]
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
        [Display(Name = "Sunny")]
        Sunny,

        [Display(Name = "Cloudy")]
        Cloudy,
        
        [Display(Name = "Sunny/Cloudy")]
        SunnyCloudy,
        
        [Display(Name = "Rainy")]
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
                    weatherIconClass = IconHelper.GetIconClass(NamedIcon.Sun);
                    break;
                case WeatherType.Cloudy:
                    weatherIconClass = IconHelper.GetIconClass(NamedIcon.Cloud);
                    break;
                case WeatherType.SunnyCloudy:
                    weatherIconClass = IconHelper.GetIconClass(NamedIcon.CloudSun);
                    break;
                case WeatherType.Rainy:
                    weatherIconClass = IconHelper.GetIconClass(NamedIcon.Rain);
                    break;
            }

            return weatherIconClass;
        }

        public static string GetFormattedWeatherNotes(WeatherType weather, int temperatureDegreesCelsius, int windMph)
        {
            string weatherNotes = $"{temperatureDegreesCelsius}°C, {weather.GetEnumDisplayName()}, {windMph}mph wind";
            return weatherNotes;
        }

        public static string GetEventName(EventResult result)
        {
            string eventName = $"{result.Sport} on {result.EventDate:dd/MM/yy}";

            if (result.Course.HasValue)
            {
                eventName = $"{result.Course.Value.GetEnumDisplayName()} {result.EventDate:yyyy}";

                // If this is a race series display the month and year.
                if (result.Course.Value == Course.Leeds5K
                    || result.Course.Value == Course.LoxleyLash5K
                    || result.Course.Value == Course.Trust10Clumber
                    || result.Course.Value == Course.Trust10Longshaw
                    || result.Course.Value == Course.York5K)
                {
                    eventName = $"{result.Course.Value.GetEnumDisplayName()} {result.EventDate:MMM} {result.EventDate:yyyy}";
                }

                // Parkrun doesn't need the month or year.
                if (result.Course.GetEnumDisplayName().StartsWith("Parkrun"))
                {
                    eventName = result.Course.Value.GetEnumDisplayName();
                }

                // Additional sport-specific formatting.
                if (result.Sport == SportType.Triathlon || result.Sport == SportType.Duathlon)
                {
                    eventName = result.Course.Value.GetEnumDisplayName();
                }
                else if (result.Sport == SportType.Bike)
                {
                    eventName = result.Course.Value.GetEnumDisplayName();
                }
                else if (result.Sport == SportType.Swim)
                {
                    eventName = $"{result.Course.Value.GetEnumDisplayName()} {GetFormattedDistance(result.Distance, result.DistanceUnit, result.Sport)} TT";
                }
            }

            return eventName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Helpers
{
    public static class RunHelper
    {
        public static string GetFormattedAvgPace(TimeSpan? avgRunPaceMinMi)
        {
            string avgPaceFormatted = "-";

            if (avgRunPaceMinMi.HasValue)
            {
                avgPaceFormatted = $"{avgRunPaceMinMi.Value.Minutes}:{avgRunPaceMinMi.Value.Seconds:D2} min/mi";
            }

            return avgPaceFormatted;
        }

        public static string GetRunPaceMinMi(double distance, DistanceUnit distanceUnit, TimeSpan totalTime)
        {
            double distanceInMiles = 0;
            TimeSpan? paceTimeSpan = null;

            if (distanceUnit == DistanceUnit.Miles)
            {
                if (distance == 13.1 || distance == 26.2)
                {
                    distanceInMiles = distance;
                }
            }
            else if (distanceUnit == DistanceUnit.Kilometres)
            {
                if (distance == 5)
                {
                    distanceInMiles = 3.1;
                }
                else if (distance == 10)
                {
                    distanceInMiles = 6.2;
                }
            }

            if (distanceInMiles > 0 && totalTime.TotalSeconds > 0)
            {
                var paceInSeconds = totalTime.TotalSeconds / distanceInMiles;
                
                paceTimeSpan = TimeSpan.FromSeconds(Math.Round(paceInSeconds, 2));
            }

            string formattedAvgPace = GetFormattedAvgPace(paceTimeSpan);

            return formattedAvgPace;
        }
    }
}

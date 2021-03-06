using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;

namespace TriResultsV2.Helpers
{
    public static class SwimHelper
    {
        public static string Get25MetreSwimPace(double distanceInMetres, TimeSpan swimTime)
        {
            double numberOf25MetreLaps = distanceInMetres / 25;
            double secondsPer25MetreLap = swimTime.TotalSeconds / numberOf25MetreLaps;
            string swimPace = $"{Math.Round(secondsPer25MetreLap, 1):F1} sec/25m";
            return swimPace;
        }

        /// <summary>
        /// Returns the Critical Swim Speed (CSS) details based on the 200m and 400m time trial times.
        /// CSS calculation from Swim Smooth - http://previous.swimsmooth.com/training.html.
        /// </summary>
        public static string GetSwimCssDetails(TimeSpan time200m, TimeSpan time400m)
        {
            double metresPerSec = (400 - 200) / (time400m.TotalSeconds - time200m.TotalSeconds);

            double secsPer100m = 100 / metresPerSec;
            var ts100mPace = TimeSpan.FromSeconds(Math.Round(secsPer100m, 0));

            double secsPer25m = secsPer100m / 4;

            string cssDetails = $"CSS: {ts100mPace.Minutes}:{ts100mPace.Seconds}/100m (tempo trainer: {Math.Round(secsPer25m, 1):F1} sec/25m)";

            return cssDetails;
        }

        public static void SetSwimPersonalBest(List<EventResult> eventResults, double distance)
        {
            if (eventResults.Any())
            {
                var personalBestResult = eventResults.Where(e => e.Distance == distance && e.ExcludeFromPersonalBestCalculation == false).OrderBy(e => e.TotalTime).FirstOrDefault();

                if (personalBestResult != null)
                {
                    personalBestResult.PersonalBest = true;
                }
            }
        }
    }
}

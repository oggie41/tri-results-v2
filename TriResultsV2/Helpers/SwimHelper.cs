using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Helpers
{
    public static class SwimHelper
    {
        public static string Get25MetreSwimPace(int distanceInMetres, TimeSpan swimTime)
        {
            int numberOf25MetreLaps = distanceInMetres / 25;
            double secondsPer25MetreLap = swimTime.TotalSeconds / numberOf25MetreLaps;
            string swimPace = $"{Math.Round(secondsPer25MetreLap, 1)} sec/25m";
            return swimPace;
        }
    }
}

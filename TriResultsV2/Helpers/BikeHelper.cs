using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Helpers
{
    public static class BikeHelper
    {
        public static string GetFormattedAvgSpeed(double? avgBikeSpeedMph)
        {
            string avgSpeedFormatted = "-";

            if (avgBikeSpeedMph.HasValue)
            {
                avgSpeedFormatted = $"{Math.Round(avgBikeSpeedMph.Value, 1)} mph";
            }

            return avgSpeedFormatted;
        }
    }
}

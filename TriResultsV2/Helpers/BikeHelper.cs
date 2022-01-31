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
                avgSpeedFormatted = $"{Math.Round(avgBikeSpeedMph.Value, 1):F1} mph";
            }

            return avgSpeedFormatted;
        }

        public static string GetFormattedAvgPowerHtml(double avgPowerInWatts, double? normalizedPowerInWatts, bool displayAsCaption = true)
        {
            string captionCss = string.Empty;

            if (displayAsCaption) 
            {
                captionCss = "figure-caption";
            }

            string tooltip = $"Avg Power";

            if (normalizedPowerInWatts.HasValue)
            {
                tooltip = $"Avg Power: {Math.Round(avgPowerInWatts, 0)}w / NP: {Math.Round(normalizedPowerInWatts.Value, 0)}w";
            }

            string avgPowerFormatted = $"<div class=\"d-inline-block text-nowrap {captionCss}\" title=\"{tooltip}\" data-bs-toggle=\"tooltip\">" +
                                       $"  <i class=\"{IconHelper.GetIconClass(NamedIcon.Power)}\"></i> {Math.Round(avgPowerInWatts, 0)}w" +
                                       $"</div>";
            return avgPowerFormatted;
        }
    }
}

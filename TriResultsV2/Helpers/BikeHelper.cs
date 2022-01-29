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

        public static string GetFormattedAvgPowerHtml(double avgPowerInWatts, bool displayAsCaption = true)
        {
            string captionCss = string.Empty;

            if (displayAsCaption)
            {
                captionCss = "figure-caption";
            }

            string avgPowerFormatted = $"<div class=\"d-inline-block {captionCss}\" title=\"Average Power\" data-bs-toggle=\"tooltip\"><i class=\"{IconHelper.GetIconClass(NamedIcon.Power)}\"></i> {Math.Round(avgPowerInWatts, 0)}w</div>";
            return avgPowerFormatted;
        }
    }
}

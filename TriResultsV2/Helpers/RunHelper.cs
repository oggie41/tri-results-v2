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
    }
}

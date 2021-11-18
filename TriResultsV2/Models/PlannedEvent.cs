using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;

namespace TriResultsV2.Models
{
    public class PlannedEvent
    {
        public DateTime EventDate { get; set; }

        public SportType Sport { get; set; }

        public double? Distance { get; set; }

        public DistanceUnit? DistanceUnit { get; set; }

        public string EventName { get; set; }
        
        public string EventUrl { get; set; }

        public bool Entered { get; set; } = false;
    }
}

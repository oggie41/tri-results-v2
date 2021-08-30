using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;

namespace TriResultsV2.Models
{
    public class EventResult
    {
        public long Id { get; set; }

        public long? GarminId { get; set; }

        public SportType Sport { get; set; }

        public string Distance { get; set; }
        
        public DateTime EventDate { get; set; }
        
        public string EventName { get; set; }

        public TimeSpan TotalTime { get; set; }
        
        public string AvgPaceSpeed { get; set; }

        public string Position { get; set; }

        public bool PersonalBest { get; set; } = false;
    }
}

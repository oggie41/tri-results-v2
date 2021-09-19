﻿using System;
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

        public EventType EventType { get; set; } = EventType.Standard;

        public double Distance { get; set; }

        public DistanceUnit DistanceUnit { get; set; }
        
        public DateTime EventDate { get; set; }
        
        public string EventName { get; set; }

        public TimeSpan TotalTime { get; set; }
        
        public TimeSpan? AvgRunPaceMinMi { get; set; }
        
        public double? AvgBikeSpeedMph { get; set; }

        public int? TotalParticipants { get; set; }

        public int? OverallPosition { get; set; }

        public bool PersonalBest { get; set; } = false;
    }
}
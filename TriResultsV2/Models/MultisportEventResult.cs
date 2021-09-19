﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;

namespace TriResultsV2.Models
{
    public class MultisportEventResult : EventResult
    {
        public bool Expanded { get; set; } = false;

        public double Discipline1Distance { get; set; }
        
        public DistanceUnit Discipline1DistanceUnit { get; set; }
        
        public double Discipline2Distance { get; set; }
        
        public DistanceUnit Discipline2DistanceUnit { get; set; }
        
        public double Discipline3Distance { get; set; }
        
        public DistanceUnit Discipline3DistanceUnit { get; set; }

        public SwimType? SwimType { get; set; }

        public TimeSpan Discipline1Time { get; set; }

        public TimeSpan? ActualSwimTime { get; set; }

        public TimeSpan T1Time { get; set; }

        public TimeSpan Discipline2Time { get; set; }

        public TimeSpan T2Time { get; set; }

        public TimeSpan Discipline3Time { get; set; }

        public int? CompareWithEventId { get; set; }

        public string Discipline1PaceSpeed { get; set; }

        public TimeSpan? Discipline1AvgRunPaceMinMi { get; set; }

        public double? Discipline2AvgBikeSpeedMph { get; set; }

        public TimeSpan? Discipline3AvgRunPaceMinMi { get; set; }

        public int? Discipline1Position { get; set; }

        public int? T1Position { get; set; }

        public int? Discipline2Position { get; set; }

        public int? T2Position { get; set; }

        public int? Discipline3Position { get; set; }
        
        public WeatherType Weather { get; set; }

        public string WeatherNotes { get; set; }

        public string EventNotes { get; set; }

        public List<string> EventFigures { get; set; } = new List<string>();

        public void AddEventFigure(string figure)
        {
            if (EventFigures == null)
            {
                EventFigures = new List<string>();
            }

            EventFigures.Add(figure);
        }
    }
}
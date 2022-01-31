using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Helpers;

namespace TriResultsV2.Models
{
    public class MultisportEventResult : EventResult
    {
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

        public long? CompareWithEventId { get; set; }

        public TimeSpan? Discipline1AvgRunPaceMinMi { get; set; }

        public TimeSpan? Discipline3AvgRunPaceMinMi { get; set; }

        public int? Discipline1Position { get; set; }

        public int? T1Position { get; set; }

        public int? Discipline2Position { get; set; }

        public int? T2Position { get; set; }

        public int? Discipline3Position { get; set; }
        
        public WeatherType Weather { get; set; }

        public int TemperatureDegreesCelsius { get; set; }

        public int WindMph { get; set; }

        public string EventNotes { get; set; }
    }
}

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
        
        public long? IntervalsIcuId { get; set; }

        public SportType Sport { get; set; }

        public EventType EventType { get; set; } = EventType.Standard;

        public Course? Course { get; set; }

        public double Distance { get; set; }

        public DistanceUnit DistanceUnit { get; set; }

        public DateTime EventDate { get; set; }
        
        public string EventName { get; set; }

        public TimeSpan TotalTime { get; set; }
        
        public TimeSpan? AvgRunPaceMinMi { get; set; }
        
        public double? AvgBikeSpeedMph { get; set; }

        public double? AvgBikePower { get; set; }

        public int? TotalParticipants { get; set; }

        public int? OverallPosition { get; set; }

        public bool PersonalBest { get; set; } = false;

        public List<EventFigure> EventFigures { get; set; } = new List<EventFigure>();

        public string OfficialResultsUrl { get; set; }
        
        public bool AdvancedAnalysisAvailable {
            get
            {
                bool advancedAnalysisAvailable = GarminId.HasValue || IntervalsIcuId.HasValue;
                return advancedAnalysisAvailable;
            }
        }

        public void AddEventFigure(string figureText, NamedIcon figureIcon = NamedIcon.Info)
        {
            if (EventFigures == null)
            {
                EventFigures = new List<EventFigure>();
            }

            var eventFigure = new EventFigure
            {
                Icon = figureIcon, 
                Text = figureText
            };

            EventFigures.Add(eventFigure);
        }
    }
}

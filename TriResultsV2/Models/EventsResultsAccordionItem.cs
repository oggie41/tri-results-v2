using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Models
{
    public class EventsResultsAccordionItem
    {
        public string ContentId { get; set; }
        
        public string HeaderText { get; set; }

        public bool Expanded { get; set; } = false;

        public List<EventResult> EventResults { get; set; } = new List<EventResult>();
    }
}

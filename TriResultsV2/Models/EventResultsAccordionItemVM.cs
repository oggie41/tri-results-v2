using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Models
{
    public class EventResultsAccordionItemVM
    {
        public string ContentId { get; set; }
        
        public string HeaderText { get; set; }

        public bool Expanded { get; set; } = false;

        public bool PersonalRecordsItem { get; set; } = false;

        public IEnumerable<EventResult> EventResults { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Models
{
    public class EventResultsTableVM
    {
        public string ContentId { get; set; }

        public bool PersonalRecordsTable { get; set; } = false;

        public IEnumerable<EventResult> EventResults { get; set; }
    }
}

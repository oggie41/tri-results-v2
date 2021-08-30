using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Models
{
    public class EventResultsTableVM
    {
        public bool PersonalRecordsTable { get; set; } = false;

        public IEnumerable<EventResult> EventResults { get; set; }
    }
}

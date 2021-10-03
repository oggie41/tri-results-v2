using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2.Models
{
    public class MultisportEventResultsAccordionVM
    {
        public string ContentId { get; set; }

        public bool DisplayNotes { get; set; } = false;

        public IEnumerable<MultisportEventResult> MultisportEventResults { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TriResultsV2.Helpers;
using TriResultsV2.Models;

namespace TriResultsV2.Pages
{
    public class SwimModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<EventResult> SwimPersonalBests { get; private set; } = new List<EventResult>();

        public EventsResultsAccordionItem SwimResults200MetreAccordionItem { get; private set; } = new EventsResultsAccordionItem();
        public EventsResultsAccordionItem SwimResults400MetreAccordionItem { get; private set; } = new EventsResultsAccordionItem();

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                SwimPersonalBests = new List<EventResult>();

                #region 200 Metre TT Results
                var swimResults200MetreTT = new List<EventResult>();

                var swimResult3221940710_1 = new EventResult
                {
                    Id = 3221940710,
                    GarminId = 3221940710,
                    Sport = SportType.Swim,
                    Distance = EventHelper.Distance200Metres,
                    EventDate = new DateTime(2018, 12, 12),
                    EventName = "Westfield 200m TT",
                    TotalTime = new TimeSpan(0, 3, 18),
                    AvgPaceSpeed = "25.0 sec/25m"
                };
                swimResults200MetreTT.Add(swimResult3221940710_1);
                SwimPersonalBests.Add(swimResult3221940710_1);

                SwimResults200MetreAccordionItem = new EventsResultsAccordionItem
                {
                    ContentId = "div-200m-tts",
                    HeaderText = "200m TTs",
                    EventResults = swimResults200MetreTT
                };
                #endregion

                #region 400 Metre TT Results
                var swimResults400MetreTT = new List<EventResult>();

                var swimResult3221940710_2 = new EventResult
                {
                    Id = 3221940710,
                    GarminId = 3221940710,
                    Sport = SportType.Swim,
                    Distance = EventHelper.Distance400Metres,
                    EventDate = new DateTime(2018, 12, 12),
                    EventName = "Westfield 400m TT",
                    TotalTime = new TimeSpan(0, 6, 52),
                    AvgPaceSpeed = "26.0 sec/25m"
                };
                swimResults400MetreTT.Add(swimResult3221940710_2);
                SwimPersonalBests.Add(swimResult3221940710_2);

                SwimResults400MetreAccordionItem = new EventsResultsAccordionItem
                {
                    ContentId = "div-400m-tts",
                    HeaderText = "400m TTs",
                    EventResults = swimResults400MetreTT
                };
                #endregion
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return Page();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TriResultsV2.Helpers;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Pages
{
    public class SwimModel : PageModel
    {
        protected ILogger<SwimModel> Logger { get; private set; }
        protected ISwimService SwimService { get; private set; }

        public EventResultsTableVM PersonalRecordsTable { get; private set; } = new EventResultsTableVM();

        public EventResultsAccordionItemVM SwimResults200MetreAccordionItem { get; private set; } = new EventResultsAccordionItemVM();
        public EventResultsAccordionItemVM SwimResults400MetreAccordionItem { get; private set; } = new EventResultsAccordionItemVM();

        public SwimModel(ILogger<SwimModel> logger, ISwimService swimService)
        {
            Logger = logger;
            SwimService = swimService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                var swimPersonalRecords = new List<EventResult>();

                // 200 Metre TT Results.
                var swimResults200MetreTT = await SwimService.Get200MetreTTResultsAsync();
                swimPersonalRecords.AddRange(swimResults200MetreTT.Where(res => res.PersonalBest));

                // 400 Metre TT Results.
                var swimResults400MetreTT = await SwimService.Get400MetreTTResultsAsync();
                swimPersonalRecords.AddRange(swimResults400MetreTT.Where(res => res.PersonalBest));

                // Calculate the CSS details for the 200m results.
                foreach (var result200m in swimResults200MetreTT)
                {
                    if (result200m.GarminId.HasValue)
                    {
                        var result400m = swimResults400MetreTT.FirstOrDefault(r => r.GarminId == result200m.GarminId);

                        if (result400m != null)
                        {
                            result200m.AddEventFigure(SwimHelper.GetSwimCssDetails(result200m.TotalTime, result400m.TotalTime), NamedIcon.Stopwatch);
                        }
                    }
                }

                // Calculate the CSS details for the 400m results.
                foreach (var result400m in swimResults400MetreTT)
                {
                    if (result400m.GarminId.HasValue)
                    {
                        var result200m = swimResults200MetreTT.FirstOrDefault(r => r.GarminId == result400m.GarminId);

                        if (result200m != null)
                        {
                            result400m.AddEventFigure(SwimHelper.GetSwimCssDetails(result200m.TotalTime, result400m.TotalTime), NamedIcon.Stopwatch);
                        }
                    }
                }

                SwimResults200MetreAccordionItem = new EventResultsAccordionItemVM
                {
                    ContentId = "200m-tts",
                    HeaderText = "200m TTs",
                    EventResults = swimResults200MetreTT
                };

                SwimResults400MetreAccordionItem = new EventResultsAccordionItemVM
                {
                    ContentId = "400m-tts",
                    HeaderText = "400m TTs",
                    EventResults = swimResults400MetreTT,
                    Expanded = true
                };

                // Personal Records.
                PersonalRecordsTable = new EventResultsTableVM()
                {
                    PersonalRecordsTable = true,
                    EventResults = swimPersonalRecords
                };
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }

            return Page();
        }
    }
}

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

        public EventResultsAccordionItemVM SwimCssTestResultsAccordionItem { get; private set; } = new EventResultsAccordionItemVM();

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

                // CSS Test Results.
                var swimCssTestResults = await SwimService.GetCssTestResultsAsync();
                swimPersonalRecords.AddRange(swimCssTestResults.Where(res => res.PersonalBest));

                // Calculate the CSS details.
                foreach (var result in swimCssTestResults)
                {
                    if (result.Distance == 400 && result.DistanceUnit == DistanceUnit.Metres)
                    {
                        if (result.GarminId.HasValue)
                        {
                            var result200m = swimCssTestResults.FirstOrDefault(r => r.GarminId == result.GarminId && r.Distance == 200 && r.DistanceUnit == DistanceUnit.Metres);

                            if (result200m != null)
                            {
                                result.AddEventFigure(SwimHelper.GetSwimCssDetails(result200m.TotalTime, result.TotalTime), NamedIcon.Stopwatch);
                            }
                        }
                    }
                }

                SwimCssTestResultsAccordionItem = new EventResultsAccordionItemVM
                {
                    ContentId = "css-tests",
                    HeaderText = "Critical Swim Speed (CSS) Tests",
                    EventResults = swimCssTestResults,
                    SwimCssTestsItem = true,
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

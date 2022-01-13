using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Pages
{
    public class EventDiaryModel : PageModel
    {
        protected ILogger<RunModel> Logger { get; private set; }
        protected IDiaryService DiaryService { get; private set; }

        public IEnumerable<PlannedEvent> PlannedEvents { get; private set; }

        public EventDiaryModel(ILogger<RunModel> logger, IDiaryService diaryService)
        {
            Logger = logger;
            DiaryService = diaryService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                var plannedEvents = await DiaryService.GetPlannedEventsAsync();
                
                // Ensure only future events are displayed.
                PlannedEvents = plannedEvents.Where(pe => pe.EventDate >= DateTime.Today).OrderBy(pe => pe.EventDate);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }

            return Page();
        }
    }
}

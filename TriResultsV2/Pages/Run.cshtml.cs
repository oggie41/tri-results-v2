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
    public class RunModel : PageModel
    {
        protected ILogger<RunModel> Logger { get; private set; }
        protected IRunService RunService { get; private set; }

        public EventResultsTableVM PersonalRecordsTable { get; private set; } = new EventResultsTableVM();

        public EventResultsAccordionItemVM RunResults5KAccordionItem { get; private set; } = new EventResultsAccordionItemVM();
        public EventResultsAccordionItemVM RunResults10KAccordionItem { get; private set; } = new EventResultsAccordionItemVM();
        public EventResultsAccordionItemVM RunResultsHmAccordionItem { get; private set; } = new EventResultsAccordionItemVM();
        public EventResultsAccordionItemVM RunResultsMsrAccordionItem { get; private set; } = new EventResultsAccordionItemVM();

        public RunModel(ILogger<RunModel> logger, IRunService runService)
        {
            Logger = logger;
            RunService = runService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                var runPersonalRecords = new List<EventResult>();

                // 5K Results.
                var runResults5K = await RunService.Get5KResultsAsync();
                runPersonalRecords.AddRange(runResults5K.Where(res => res.PersonalBest));

                RunResults5KAccordionItem = new EventResultsAccordionItemVM
                {
                    ContentId = "5k-races",
                    HeaderText = "5K Races",
                    EventResults = runResults5K
                };

                // 10K Results.
                var runResults10K = await RunService.Get10KResultsAsync();
                runPersonalRecords.AddRange(runResults10K.Where(res => res.PersonalBest));

                RunResults10KAccordionItem = new EventResultsAccordionItemVM
                {
                    ContentId = "10k-races",
                    HeaderText = "10K Races",
                    EventResults = runResults10K
                };

                // Half Marathon Results.
                var runResultsHm = await RunService.GetHalfMarathonResultsAsync();
                runPersonalRecords.AddRange(runResultsHm.Where(res => res.PersonalBest));

                RunResultsHmAccordionItem = new EventResultsAccordionItemVM
                {
                    ContentId = "hm-races",
                    HeaderText = "Half Marathon Races",
                    EventResults = runResultsHm
                };

                // Multi-Stage Results.
                var runResultsMsr = await RunService.GetMultiStageResultsAsync();

                RunResultsMsrAccordionItem = new EventResultsAccordionItemVM
                {
                    ContentId = "ms-races",
                    HeaderText = "Multi-Stage Races",
                    EventResults = runResultsMsr
                };

                // Personal Records.
                PersonalRecordsTable = new EventResultsTableVM()
                {
                    ContentId = "run-pbs",
                    PersonalRecordsTable = true,
                    EventResults = runPersonalRecords
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

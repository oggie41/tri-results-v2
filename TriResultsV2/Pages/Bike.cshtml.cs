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
    public class BikeModel : PageModel
    {
        protected ILogger<BikeModel> Logger { get; private set; }
        protected IBikeService BikeService { get; private set; }

        public EventResultsTableVM PersonalRecordsTable { get; private set; } = new EventResultsTableVM();

        public EventResultsAccordionItemVM BikeResults10MiAccordionItem { get; private set; } = new EventResultsAccordionItemVM();
        public EventResultsAccordionItemVM BikeResults25MiAccordionItem { get; private set; } = new EventResultsAccordionItemVM();

        public BikeModel(ILogger<BikeModel> logger, IBikeService bikeService)
        {
            Logger = logger;
            BikeService = bikeService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                var bikePersonalRecords = new List<EventResult>();

                // 10 Mile TT Results.
                var bikeResults10MileTT = await BikeService.Get10MileTTResultsAsync();
                bikePersonalRecords.AddRange(bikeResults10MileTT.Where(res => res.PersonalBest));

                BikeResults10MiAccordionItem = new EventResultsAccordionItemVM
                {
                    ContentId = "10mi-tts",
                    HeaderText = "10 Mile TTs",
                    EventResults = bikeResults10MileTT
                };

                // 25 Mile TT Results.
                var bikeResults25MileTT = await BikeService.Get25MileTTResultsAsync();

                BikeResults25MiAccordionItem = new EventResultsAccordionItemVM
                {
                    ContentId = "25mi-tts",
                    HeaderText = "25 Mile TTs",
                    EventResults = bikeResults25MileTT
                };

                // Personal Records.
                PersonalRecordsTable = new EventResultsTableVM()
                {
                    PersonalRecordsTable = true,
                    EventResults = bikePersonalRecords
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

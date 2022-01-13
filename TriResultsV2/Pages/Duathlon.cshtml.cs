using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;
using TriResultsV2.Services.Interfaces;

namespace TriResultsV2.Pages
{
    public class DuathlonModel : PageModel
    {
        private readonly ILogger<DuathlonModel> _logger;
        protected IDuathlonService DuathlonService { get; private set; }

        public bool DisplayNotes { get; set; } = false;

        public MultisportEventResultsAccordionVM DuathlonResultsAccordion { get; private set; } = new MultisportEventResultsAccordionVM();

        public DuathlonModel(ILogger<DuathlonModel> logger, ITriathlonService triathlonService, IDuathlonService duathlonService)
        {
            _logger = logger;
            DuathlonService = duathlonService;
        }

        public async Task<IActionResult> OnGetAsync(string displayNotes = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(displayNotes))
                {
                    DisplayNotes = bool.Parse(displayNotes);
                }

                // Duathlon Results.
                var duathlonResults = await DuathlonService.GetResultsAsync();

                DuathlonResultsAccordion = new MultisportEventResultsAccordionVM
                {
                    ContentId = "duathlon-races",
                    DisplayNotes = DisplayNotes,
                    MultisportEventResults = duathlonResults
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return Page();
        }
    }
}

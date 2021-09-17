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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        protected ITriathlonService TriathlonService { get; private set; }

        public bool DisplayNotes { get; set; } = false;

        public MultisportEventResultsAccordionVM TriathlonResultsAccordion { get; private set; } = new MultisportEventResultsAccordionVM();

        public IndexModel(ILogger<IndexModel> logger, ITriathlonService triathlonService)
        {
            _logger = logger;
            TriathlonService = triathlonService;
        }

        public async Task<IActionResult> OnGetAsync(string displayNotes = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(displayNotes))
                {
                    DisplayNotes = bool.Parse(displayNotes);
                }

                // Triathlon Results.
                var triathlonResults = await TriathlonService.GetResultsAsync();

                TriathlonResultsAccordion = new MultisportEventResultsAccordionVM
                {
                    DisplayNotes = DisplayNotes,
                    MultisportEventResults = triathlonResults
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

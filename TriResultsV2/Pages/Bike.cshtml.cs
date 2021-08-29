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
    public class BikeModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<EventResult> BikePersonalBests { get; private set; } = new List<EventResult>();

        public EventsResultsAccordionItem BikeResults10MiAccordionItem { get; private set; } = new EventsResultsAccordionItem();
        public EventsResultsAccordionItem BikeResults25MiAccordionItem { get; private set; } = new EventsResultsAccordionItem();

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                BikePersonalBests = new List<EventResult>();

                #region 10 Mile TT Results
                var bikeResults10MileTT = new List<EventResult>();

                var bikeResult2684332277 = new EventResult
                {
                    Id = 2684332277,
                    GarminId = 2684332277,
                    Sport = SportType.Bike,
                    Distance = EventHelper.Distance10Miles,
                    EventDate = new DateTime(2018, 5, 8),
                    EventName = "Cuckney 10 Mile TT",
                    TotalTime = new TimeSpan(0, 27, 00),
                    AvgPaceSpeed = "22.2 mph"
                };
                bikeResults10MileTT.Add(bikeResult2684332277);
                BikePersonalBests.Add(bikeResult2684332277);

                BikeResults10MiAccordionItem = new EventsResultsAccordionItem
                {
                    ContentId = "div-10mi-tts",
                    HeaderText = "10 Mile TTs",
                    EventResults = bikeResults10MileTT
                };
                #endregion

                #region 25 Mile TT Results
                var bikeResults25MileTT = new List<EventResult>();

                var bikeResult3448107371 = new EventResult
                {
                    Id = 3448107371,
                    GarminId = 3448107371,
                    Sport = SportType.Bike,
                    Distance = EventHelper.Distance25Miles,
                    EventDate = new DateTime(2019, 3, 9),
                    EventName = "Sheffrec CC 2-Up 25 Mile TT",
                    TotalTime = new TimeSpan(1, 17, 40),
                    AvgPaceSpeed = "19.3 mph"
                };
                bikeResults25MileTT.Add(bikeResult3448107371);

                BikeResults25MiAccordionItem = new EventsResultsAccordionItem
                {
                    ContentId = "div-25mi-tts",
                    HeaderText = "25 Mile TTs",
                    EventResults = bikeResults25MileTT
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

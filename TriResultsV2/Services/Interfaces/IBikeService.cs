using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;

namespace TriResultsV2.Services.Interfaces
{
    public interface IBikeService
    {
        Task<IEnumerable<EventResult>> Get10MileTTResultsAsync();

        Task<IEnumerable<EventResult>> Get25MileTTResultsAsync();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;

namespace TriResultsV2.Services.Interfaces
{
    public interface ISwimService
    {
        Task<IEnumerable<EventResult>> Get200MetreTTResultsAsync();

        Task<IEnumerable<EventResult>> Get400MetreTTResultsAsync();
    }
}

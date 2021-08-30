using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriResultsV2.Models;

namespace TriResultsV2.Services.Interfaces
{
    public interface IRunService
    {
        Task<IEnumerable<EventResult>> Get5KResultsAsync();

        Task<IEnumerable<EventResult>> Get10KResultsAsync();
        
        Task<IEnumerable<EventResult>> GetHalfMarathonResultsAsync();
        
        Task<IEnumerable<EventResult>> GetMultiStageResultsAsync();
    }
}

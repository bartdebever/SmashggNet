using System.Collections.Generic;
using SmashggNet.Models;

namespace SmashggNet.Modules.Interfaces
{
    public interface IPhaseGroupEndpoint
    {
        Phase GetPhaseById(int phaseId, ICollection<Expand> expands);
    }
}
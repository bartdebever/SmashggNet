using System;
using System.Collections.Generic;
using SmashggHandler.Models;

namespace SmashggNet.Modules.Interfaces{
    public interface IPhaseGroupEndpoint {
        Phase GetPhaseById (int phaseId, ICollection<Expand> expands);
    }
}
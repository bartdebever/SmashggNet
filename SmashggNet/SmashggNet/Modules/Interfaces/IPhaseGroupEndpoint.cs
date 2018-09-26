using System.Collections.Generic;
using SmashggNet.Models;

namespace SmashggNet.Modules.Interfaces
{
    public interface IPhaseGroupEndpoint
    {
        /// <summary>
        /// Gets an <see cref="Phase"/> object based off the id provided
        /// </summary>
        /// <param name="phaseId">The Id of the phase object requested</param>
        /// <param name="expands">A collection of expands that need to be added to the object</param>
        /// <returns>An instance of the <see cref="Phase"/> class</returns>
        Phase GetPhaseById(int phaseId, ICollection<Expand> expands);
    }
}
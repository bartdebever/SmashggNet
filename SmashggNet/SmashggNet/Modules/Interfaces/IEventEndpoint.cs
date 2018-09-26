using System.Collections.Generic;
using SmashggNet.Models;

namespace SmashggNet.Modules.Interfaces
{
    public interface IEventEndpoint
    {
        /// <summary>
        /// Gets an event object by its Id
        /// </summary>
        /// <param name="eventId">The id of the event you want</param>
        /// <param name="expands">A collection of expands which you want expanded</param>
        /// <returns>An instance of the <see cref="Event"/> class</returns>
        Event GetEventById(int eventId, ICollection<Expand> expands);
    }
}
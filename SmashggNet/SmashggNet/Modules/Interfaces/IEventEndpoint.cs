using System.Collections.Generic;
using SmashggNet.Models;

namespace SmashggNet.Modules.Interfaces
{
    public interface IEventEndpoint
    {
        Event GetEventById(int eventId, ICollection<Expand> expands);
    }
}
using System;
using System.Collections.Generic;
using SmashggHandler.Models;

namespace SmashggNet.Modules.Interfaces{
    public interface IEventEndpoint
    {
        Event GetEventById (int eventId, ICollection<Expand> expands);
    }
}
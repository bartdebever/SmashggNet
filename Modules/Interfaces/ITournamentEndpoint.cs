using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SmashggHandler.Models;

namespace SmashggHandler.Modules.Interfaces
{
    public interface ITournamentEndpoint
    {
        Task<TournamentRoot> GetTournamentByName(string name);
        Task<TournamentScheduleRoot> GetUpcomingTournaments();
    }
}

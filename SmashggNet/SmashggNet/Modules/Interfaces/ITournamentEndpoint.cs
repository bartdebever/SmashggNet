using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SmashggHandler.Models;

namespace SmashggHandler.Modules.Interfaces
{
    public interface ITournamentEndpoint
    {
        /// <summary>
        /// Gets a tournament by its name indicated as in the url of the Smash.gg website.
        /// For example "smash.gg/tournament/pulsar-premier-league" would be named pulsar-premier-league.
        /// </summary>
        /// <param name="name">The name of the tournament object you want to get</param>
        /// <param name="expands">The fields that should be expanded</param>
        /// <returns>A TournamentRoot Object.</returns>
        Task<TournamentRoot> GetTournamentByName(string name, ICollection<Expand> expands);

        /// <summary>
        /// Gets the upcoming tournaments for all games on Smash.gg
        /// Will be configurable later on.
        /// </summary>
        /// <returns>A TournamentScheduleRoot</returns>
        Task<TournamentScheduleRoot> GetUpcomingTournaments();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using SmashggHandler.Exceptions;
using SmashggHandler.Helper;
using SmashggHandler.Models;
using SmashggHandler.Modules.Interfaces;

namespace SmashggHandler.Modules
{
    public class TournamentEndpoint : ITournamentEndpoint
    {
        private const string Uri = "http://api.smash.gg/";
        private const string TournamentEndpointUrl = "tournament/";
        private const string UpcomingTournaments = "/public/tournaments/schedule?per_page=5&filter={\"upcoming\"%3Atrue%2C\"videogameIds\"%3A\"\"%2C\"attendeeCount\"%3A[\"gt%3A200%2Clte%3A500\"%2C\"gt%3A500%2Clte%3A1000\"%2C\"gt%3A1000\"%2C\"gt%3A100%2Clte%3A200\"]}&page=1";

        /// <summary>
        /// Gets a tournament by its name indicated as in the url of the Smash.gg website.
        /// For example "smash.gg/tournament/pulsar-premier-league" would be named pulsar-premier-league.
        /// </summary>
        /// <param name="name">The name of the tournament object you want to get</param>
        /// <param name="expands">The fields that should be expanded</param>
        /// <returns>A TournamentRoot Object.</returns>
        public async Task<TournamentRoot> GetTournamentByName(string name, ICollection<Expand> expands)
        {
            var client = new RestClient(Uri);
            var expandList = ExpandHelper.GetExpandStringFromCollection(expands);

            var request = new RestRequest($"{TournamentEndpointUrl}{name}{expandList}", Method.GET);

            var response = await client.ExecuteTaskAsync(request);
            if(!response.IsSuccessful)
                throw new TournamentNotFoundException(); //Should most likely be an connection error exception

            return JsonConvert.DeserializeObject<TournamentRoot>(response.Content);
        }

        /// <summary>
        /// Gets the upcoming tournaments for all games on Smash.gg
        /// Will be configurable later on.
        /// </summary>
        /// <returns>A TournamentScheduleRoot</returns>
        public async Task<TournamentScheduleRoot> GetUpcomingTournaments()
        {
            var client = new RestClient(Uri);
            var request = new RestRequest($"{UpcomingTournaments}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            if (!response.IsSuccessful)
                throw new TournamentNotFoundException();
            return JsonConvert.DeserializeObject<TournamentScheduleRoot>(response.Content);
        }
    }
}

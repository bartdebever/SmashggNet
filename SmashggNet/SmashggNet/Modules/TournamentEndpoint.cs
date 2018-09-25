using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using SmashggNet.Exceptions;
using SmashggNet.Helper;
using SmashggNet.Models;
using SmashggNet.Modules.Interfaces;

namespace SmashggNet.Modules
{
    public class TournamentEndpoint : ITournamentEndpoint
    {
        private const string Uri = "http://api.smash.gg/";
        private const string TournamentEndpointUrl = "tournament/";
        private const string UpcomingTournaments = "/public/tournaments/schedule?per_page=5&filter={\"upcoming\"%3Atrue%2C\"videogameIds\"%3A\"\"%2C\"attendeeCount\"%3A[\"gt%3A200%2Clte%3A500\"%2C\"gt%3A500%2Clte%3A1000\"%2C\"gt%3A1000\"%2C\"gt%3A100%2Clte%3A200\"]}&page=1";

        public async Task<TournamentRoot> GetTournamentByName(string name, ICollection<Expand> expands)
        {
            var client = new RestClient(Uri);
            var expandList = ExpandHelper.GetExpandStringFromCollection(expands);

            var request = new RestRequest($"{TournamentEndpointUrl}{name}{expandList}", Method.GET);

            var response = await client.ExecuteTaskAsync(request);
            if (!response.IsSuccessful)
                throw new TournamentNotFoundException(); //Should most likely be an connection error exception

            return JsonConvert.DeserializeObject<TournamentRoot>(response.Content);
        }

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
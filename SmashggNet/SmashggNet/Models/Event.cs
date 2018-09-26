using Newtonsoft.Json;

namespace SmashggNet.Models
{
    public class Event
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// The Id of the tournament this event is held in
        /// </summary>
        [JsonProperty("tournamentId")]
        public int TournamentId { get; set; }
        /// <summary>
        /// The Id of the video game that this event corresponds to
        /// </summary>
        [JsonProperty("videogameId")]
        public int VideogameId { get; set; }
        /// <summary>
        /// The name of the event
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// A description of the event
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
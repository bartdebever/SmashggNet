using Newtonsoft.Json;

namespace SmashggNet.Models
{
    public class Seed
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// The id of the phase that this seed belongs to.
        /// </summary>
        [JsonProperty("phaseId")]
        public int PhaseId { get; set; }
        /// <summary>
        /// The seed number? 
        /// </summary>
        [JsonProperty("seedNum")]
        public int? SeedNumber { get; set; }
        /// <summary>
        /// The placement that this seed has gotten.
        /// Returns null when the seed has not been placed yet
        /// </summary>
        [JsonProperty("placement")]
        public int? Placement { get; set; }
        /// <summary>
        /// Amount of losses the seed has in the event
        /// </summary>
        [JsonProperty("losses")]
        public int? Losses { get; set; }
        /// <summary>
        /// Returns true if the placement is final
        /// </summary>
        [JsonProperty("isFinal")]
        public bool IsFinal { get; set; }
        /// <summary>
        /// Returns if the seed is actually seeded manually/by ranking
        /// </summary>
        [JsonProperty("isSeeded")]
        public bool IsSeeded { get; set; }
        /// <summary>
        /// If this player is a "Bye"
        /// </summary>
        [JsonProperty("isBye")]
        public bool IsBye { get; set; }
        /// <summary>
        /// The name of the phase this seed got to
        /// </summary>
        [JsonProperty("originPhaseName")]
        public string PhaseName { get; set; }
        /// <summary>
        /// The Phase Group Id of the phase the seed got to
        /// </summary>
        [JsonProperty("phaseGroupId")]
        public int? PhaseGroupId { get; set; }
        /// <summary>
        /// Use this id to correlate the entrant to the seed
        /// </summary>
        /// <value></value>
        [JsonProperty("entrantId")]
        public int? EntrantId { get; set; }
    }
}
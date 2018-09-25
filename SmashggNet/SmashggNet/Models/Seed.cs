using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SmashggNet.Models{
    public class Seed{
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("phaseId")]
        public int PhaseId { get; set; }
        [JsonProperty("seedNum")]
        public int? SeedNumber { get; set;}
        [JsonProperty("placement")]
        public int? Placement { get; set; }
        [JsonProperty("losses")]
        public int? Losses { get; set; }
        [JsonProperty("isFinal")]
        public bool IsFinal { get; set; }
        [JsonProperty("isSeeded")]
        public bool IsSeeded { get; set; }
        [JsonProperty("isBye")]
        public bool IsBye { get; set; }
        [JsonProperty("originPhaseName")]
        public string PhaseName { get; set; }
        [JsonProperty("phaseGroupId")]
        public int? PhaseGroupId { get; set; }
        /// <summary>
        /// Use this id to corrolate the entrant to the seed
        /// </summary>
        /// <value></value>
        [JsonProperty("entrantId")]
        public int? EntrantId { get; set; }
    }
}
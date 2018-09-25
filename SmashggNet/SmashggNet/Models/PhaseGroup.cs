using Newtonsoft.Json;
using System.Collections.Generic;

namespace SmashggNet.Models
{
    public class PhaseGroup
    {
        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }

        /// <summary>
        /// Needs to be expanded to not be empty
        /// </summary>
        /// <returns>A list of Seed objects</returns>
        [JsonProperty("seeds")]
        public List<Seed> Seeds { get; set; }

        [JsonProperty("sets")]
        public List<Set> Sets { get; set; }
    }

    public class PhaseGroupRoot
    {
        [JsonProperty("entities")]
        public PhaseGroup Entities { get; set; }
    }
}
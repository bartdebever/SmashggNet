using Newtonsoft.Json;

namespace SmashggNet.Models
{
    public class Group
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("phaseId")]
        public int PhaseId { get; set; }
    }
}
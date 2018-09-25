using Newtonsoft.Json;

namespace SmashggNet.Models
{
    public class SmashggImage
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
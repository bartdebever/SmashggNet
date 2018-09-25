using Newtonsoft.Json;

namespace SmashggNet.Models
{
    public class Videogame
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
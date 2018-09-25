using Newtonsoft.Json;

namespace SmashggNet.Models
{
    public class RootObject<Entity> where Entity : class
    {
        [JsonProperty("entities")]
        public Entity Entities { get; set; }
    }
}
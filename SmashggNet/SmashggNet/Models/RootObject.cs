using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SmashggHandler.Models
{
    public class RootObject<Entity> where Entity : class
    {
        [JsonProperty("entities")]
        public Entity Entities { get; set; }
    }
}

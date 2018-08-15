using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SmashggHandler.Models
{
    public class Videogame
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

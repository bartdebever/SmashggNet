﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SmashggHandler.Models
{
    public class SmashggImage
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

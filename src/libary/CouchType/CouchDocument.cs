using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PillowSharp.Middelware;

namespace PillowSharp.CouchType
{
    public class CouchDocument
    {
        [JsonProperty("_id")]
        public string ID { get; set; }  = null;

        [JsonProperty("_rev")]
        public string Rev { get; set; } = null;

        [JsonProperty("_deleted")]
        public bool Deleted { get; set; } = false;
    }
}
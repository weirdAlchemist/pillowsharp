using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PillowSharp.Middelware;

namespace PillowSharp.CouchType
{
    public class CouchBulk<T> where T:CouchDocument
    {
        [JsonProperty("docs")]
        public List<T> Docs { get; set; }

        public CouchBulk()
        {
            Docs = new List<T>();
        }

        public CouchBulk(T Document)
        {
            Docs = new List<T>(){Document};
        }

        public CouchBulk(List<T> Documents)
        {
            Docs = Documents;
        }
    }
}
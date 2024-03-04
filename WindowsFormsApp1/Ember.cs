using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
//using Newtonsoft.Json.Converters;
//using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Ember
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("salary")]
        public int salary { get; set; }

        [JsonPropertyName("position")]
        public string position { get; set; }

        public override string ToString()
        {
            return $"{id}, {name}, {salary}, {position}";
        }
        public string Kiiratas
        {
            get { return $"{name}"; }
        }
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static Ember[] FromJson(string json)
        {
            return JsonSerializer.Deserialize<Ember[]>(json);
        }
    }
}

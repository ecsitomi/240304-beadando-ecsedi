using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Elem
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
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal struct ConfigJSON
    {
        [JsonProperty("letters_array")]
        public string[] Letters { get; private set; }
        [JsonProperty("numbers_array")]
        public string[] Numbers { get; private set; }
        [JsonProperty("symbols_array")]
        public string[] Symbols { get; private set; }
        [JsonProperty("attempts")]
        public int Attempts { get; private set; }
    }
}

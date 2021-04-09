using Newtonsoft.Json;

namespace Aris.ServerTest.Models
{
    public class KoreGameAttributes
    {
        [JsonProperty("free_spins")]
        public string Free_Spins { get; set; }
    }
}
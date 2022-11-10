using Newtonsoft.Json;

#nullable disable

namespace HoNSharp.Models
{
    public class LastPlayerMatchesResponse
    {
        [JsonProperty("last_stats")]
        public Dictionary<string, long> LastStats { get; set; }

        [JsonProperty("success")]
        public string Success { get; set; }

        [JsonProperty("hosttime")]
        public long Hosttime { get; set; }
    }
}

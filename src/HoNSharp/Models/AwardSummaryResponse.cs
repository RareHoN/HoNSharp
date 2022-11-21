using Newtonsoft.Json;

namespace HoNSharp.Models
{
    public class AwardSummaryResponse
    {
        [JsonProperty("mvp")]
        public long? MVP { get; set; }

        [JsonProperty("awd_mann")]
        public long? TopAnnihilation { get; set; }

        [JsonProperty("awd_mqk")]
        public long? MostQuadKills { get; set; }

        [JsonProperty("awd_lgks")]
        public long? BestKillStreak { get; set; }

        [JsonProperty("awd_msd")]
        public long? MostSmackdowns { get; set; }

        [JsonProperty("awd_mkill")]
        public long? MostKills { get; set; }

        [JsonProperty("awd_masst")]
        public long? MostAssists { get; set; }

        [JsonProperty("awd_ledth")]
        public long? LeastDeaths { get; set; }

        [JsonProperty("awd_mbdmg")]
        public long? TopSiegeDamage { get; set; }

        [JsonProperty("awd_mhdd")]
        public long? TopHeroDamage { get; set; }

        [JsonProperty("awd_hcs")]
        public long? TopCreepScore { get; set; }
    }
}

using Newtonsoft.Json;

#nullable disable

namespace HoNSharp.Models
{
    public class MasteryStatsResponse
    {
        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("standing")]
        public long? Standing { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("last_activity")]
        public string LastActivity { get; set; }

        [JsonProperty("selected_upgrades")]
        public Dictionary<string, string> SelectedUpgrades { get; set; }

        [JsonProperty("level")]
        public long? Level { get; set; }

        [JsonProperty("level_exp")]
        public long? LevelExp { get; set; }

        [JsonProperty("mastery_info")]
        public Dictionary<string, MasteryInfo> MasteryInfo { get; set; }

        [JsonProperty("mastery_rewards")]
        public Dictionary<string, MasteryReward> MasteryRewards { get; set; }

        [JsonProperty("vested_threshold")]
        public long? VestedThreshold { get; set; }
    }

    public class MasteryInfo
    {
        [JsonProperty("heroname")]
        public string Heroname { get; set; }

        [JsonProperty("exp")]
        public long? Exp { get; set; }
    }

    public class MasteryReward
    {
        [JsonProperty("level")]
        public long? Level { get; set; }

        [JsonProperty("alreadygot")]
        public bool Alreadygot { get; set; }

        [JsonProperty("reward")]
        public Reward Reward { get; set; }
    }

    public class Reward
    {
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("product_local_content")]
        public string ProductLocalContent { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("points")]
        public long? Points { get; set; }

        [JsonProperty("mmpoints")]
        public long? Mmpoints { get; set; }

        [JsonProperty("tickets")]
        public long? Tickets { get; set; }
    }
}

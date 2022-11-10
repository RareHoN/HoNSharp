using Newtonsoft.Json;

#nullable disable

namespace HoNSharp.Models
{
    public class SimpleStatsResponse
    {
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("level_exp")]
        public long LevelExp { get; set; }

        [JsonProperty("hero_num")]
        public long HeroNum { get; set; }

        [JsonProperty("avatar_num")]
        public long AvatarNum { get; set; }

        [JsonProperty("total_played")]
        public long TotalPlayed { get; set; }

        [JsonProperty("mvp_num")]
        public long MvpNum { get; set; }

        [JsonProperty("selected_upgrades")]
        public Dictionary<string, string> SelectedUpgrades { get; set; }

        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("season_id")]
        public long SeasonId { get; set; }

        [JsonProperty("season_normal")]
        public Season SeasonNormal { get; set; }

        [JsonProperty("season_casual")]
        public Season SeasonCasual { get; set; }

        [JsonProperty("award_top4_name")]
        public Dictionary<string, string> AwardTop4Name { get; set; }

        [JsonProperty("award_top4_num")]
        public Dictionary<string, long> AwardTop4Num { get; set; }
    }

    public class Season
    {
        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("win_streak")]
        public long WinStreak { get; set; }

        [JsonProperty("current_level")]
        public long CurrentLevel { get; set; }
    }
}

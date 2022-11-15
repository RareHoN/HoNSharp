using Newtonsoft.Json;

#nullable disable

namespace HoNSharp.Models
{
    public class AllHeroStatsResponse
    {
        [JsonProperty("all_hero_stats")]
        public AllHeroStats AllHeroStats { get; set; }

        [JsonProperty("vested_threshold")]
        public long? VestedThreshold { get; set; }
    }

    public class AllHeroStats
    {
        [JsonProperty("ranked")]
        public Dictionary<string, Ranked> Ranked { get; set; }

        [JsonProperty("casual")]
        public Dictionary<string, Casual> Casual { get; set; }

        [JsonProperty("campaign")]
        public Dictionary<string, Campaign> Campaign { get; set; }

        [JsonProperty("campaign_casual")]
        public CampaignCasual CampaignCasual { get; set; }
    }

    public class Campaign
    {
        [JsonProperty("cli_name")]
        public string CliName { get; set; }

        [JsonProperty("cam_ph_used")]
        public long? CamPhUsed { get; set; }

        [JsonProperty("cam_ph_wins")]
        public long? CamPhWins { get; set; }

        [JsonProperty("cam_ph_losses")]
        public long? CamPhLosses { get; set; }

        [JsonProperty("cam_ph_herokills")]
        public long? CamPhHerokills { get; set; }

        [JsonProperty("cam_ph_deaths")]
        public long? CamPhDeaths { get; set; }

        [JsonProperty("cam_ph_heroassists")]
        public long? CamPhHeroassists { get; set; }

        [JsonProperty("cam_ph_teamcreepkills")]
        public long? CamPhTeamcreepkills { get; set; }

        [JsonProperty("cam_ph_denies")]
        public long? CamPhDenies { get; set; }

        [JsonProperty("cam_ph_exp")]
        public long? CamPhExp { get; set; }

        [JsonProperty("cam_ph_gold")]
        public long? CamPhGold { get; set; }

        [JsonProperty("cam_ph_actions")]
        public long? CamPhActions { get; set; }

        [JsonProperty("cam_ph_time_earning_exp")]
        public long? CamPhTimeEarningExp { get; set; }
    }

    public class CampaignCasual
    {
    }

    public class Casual
    {
        [JsonProperty("cli_name")]
        public string CliName { get; set; }

        [JsonProperty("cs_ph_used")]
        public long? CsPhUsed { get; set; }

        [JsonProperty("cs_ph_wins")]
        public long? CsPhWins { get; set; }

        [JsonProperty("cs_ph_losses")]
        public long? CsPhLosses { get; set; }

        [JsonProperty("cs_ph_herokills")]
        public long? CsPhHerokills { get; set; }

        [JsonProperty("cs_ph_deaths")]
        public long? CsPhDeaths { get; set; }

        [JsonProperty("cs_ph_heroassists")]
        public long? CsPhHeroassists { get; set; }

        [JsonProperty("cs_ph_teamcreepkills")]
        public long? CsPhTeamcreepkills { get; set; }

        [JsonProperty("cs_ph_denies")]
        public long? CsPhDenies { get; set; }

        [JsonProperty("cs_ph_exp")]
        public long? CsPhExp { get; set; }

        [JsonProperty("cs_ph_gold")]
        public long? CsPhGold { get; set; }

        [JsonProperty("cs_ph_actions")]
        public long? CsPhActions { get; set; }

        [JsonProperty("cs_ph_time_earning_exp")]
        public long? CsPhTimeEarningExp { get; set; }
    }

    public class Ranked
    {
        [JsonProperty("cli_name")]
        public string CliName { get; set; }

        [JsonProperty("rnk_ph_used")]
        public long? RnkPhUsed { get; set; }

        [JsonProperty("rnk_ph_wins")]
        public long? RnkPhWins { get; set; }

        [JsonProperty("rnk_ph_losses")]
        public long? RnkPhLosses { get; set; }

        [JsonProperty("rnk_ph_herokills")]
        public long? RnkPhHerokills { get; set; }

        [JsonProperty("rnk_ph_deaths")]
        public long? RnkPhDeaths { get; set; }

        [JsonProperty("rnk_ph_heroassists")]
        public long? RnkPhHeroassists { get; set; }

        [JsonProperty("rnk_ph_teamcreepkills")]
        public long? RnkPhTeamcreepkills { get; set; }

        [JsonProperty("rnk_ph_denies")]
        public long? RnkPhDenies { get; set; }

        [JsonProperty("rnk_ph_exp")]
        public long? RnkPhExp { get; set; }

        [JsonProperty("rnk_ph_gold")]
        public long? RnkPhGold { get; set; }

        [JsonProperty("rnk_ph_actions")]
        public long? RnkPhActions { get; set; }

        [JsonProperty("rnk_ph_time_earning_exp")]
        public long? RnkPhTimeEarningExp { get; set; }
    }
}

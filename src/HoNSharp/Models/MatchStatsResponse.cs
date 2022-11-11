using Newtonsoft.Json;

#nullable disable

namespace HoNSharp.Models
{
    public partial class MatchStatsResponse
    {
        [JsonProperty("match_summ")]
        public Dictionary<string, MatchSummary> MatchSummary { get; set; }

        [JsonProperty("match_player_stats")]
        public Dictionary<string, Dictionary<string, MatchPlayerStat>> MatchPlayerStats { get; set; }

        [JsonProperty("inventory")]
        public Dictionary<string, Dictionary<string, InventoryItem>> Inventory { get; set; }
    }

    public class InventoryItem
    {
        [JsonProperty("slot_1")]
        public string Slot1 { get; set; }

        [JsonProperty("slot_2")]
        public string Slot2 { get; set; }

        [JsonProperty("slot_3")]
        public string Slot3 { get; set; }

        [JsonProperty("slot_4")]
        public string Slot4 { get; set; }

        [JsonProperty("slot_5")]
        public string Slot5 { get; set; }

        [JsonProperty("slot_6")]
        public string Slot6 { get; set; }
    }

    public class MatchPlayerStat
    {
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("clan_tag")]
        public object ClanTag { get; set; }

        [JsonProperty("clan_id")]
        public long ClanId { get; set; }

        [JsonProperty("team")]
        public long Team { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("group_num")]
        public long GroupNum { get; set; }

        [JsonProperty("benefit")]
        public long Benefit { get; set; }

        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("discos")]
        public long Discos { get; set; }

        [JsonProperty("concedes")]
        public long Concedes { get; set; }

        [JsonProperty("kicked")]
        public long Kicked { get; set; }

        [JsonProperty("social_bonus")]
        public long SocialBonus { get; set; }

        [JsonProperty("used_token")]
        public long UsedToken { get; set; }

        [JsonProperty("pub_skill")]
        public long PubSkill { get; set; }

        [JsonProperty("pub_count")]
        public long PubCount { get; set; }

        [JsonProperty("amm_team_rating")]
        public double AmmTeamRating { get; set; }

        [JsonProperty("amm_team_count")]
        public long AmmTeamCount { get; set; }

        [JsonProperty("concedevotes")]
        public long Concedevotes { get; set; }

        [JsonProperty("herokills")]
        public long Herokills { get; set; }

        [JsonProperty("herodmg")]
        public long Herodmg { get; set; }

        [JsonProperty("herokillsgold")]
        public long HeroKillsGold { get; set; }

        [JsonProperty("heroassists")]
        public long HeroAssists { get; set; }

        [JsonProperty("heroexp")]
        public long Heroexp { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("buybacks")]
        public long Buybacks { get; set; }

        [JsonProperty("goldlost2death")]
        public long GoldLostToDeath { get; set; }

        [JsonProperty("secs_dead")]
        public long SecsDead { get; set; }

        [JsonProperty("teamcreepkills")]
        public long TeamCreepKills { get; set; }

        [JsonProperty("teamcreepdmg")]
        public long TeamCreepDamage { get; set; }

        [JsonProperty("teamcreepgold")]
        public long TeamCreepGold { get; set; }

        [JsonProperty("teamcreepexp")]
        public long TeamCreepeXP { get; set; }

        [JsonProperty("neutralcreepkills")]
        public long NeutralCreepKills { get; set; }

        [JsonProperty("neutralcreepdmg")]
        public long NeutralCreepDamage { get; set; }

        [JsonProperty("neutralcreepgold")]
        public long NeutralCreepGold { get; set; }

        [JsonProperty("neutralcreepexp")]
        public long NeutralCreepeXP { get; set; }

        [JsonProperty("bdmg")]
        public long BDamage { get; set; }

        [JsonProperty("razed")]
        public long Razed { get; set; }

        [JsonProperty("bdmgexp")]
        public long BdmgeXP { get; set; }

        [JsonProperty("bgold")]
        public long Bgold { get; set; }

        [JsonProperty("denies")]
        public long Denies { get; set; }

        [JsonProperty("exp_denied")]
        public long ExpDenied { get; set; }

        [JsonProperty("gold")]
        public long Gold { get; set; }

        [JsonProperty("gold_spent")]
        public long GoldSpent { get; set; }

        [JsonProperty("exp")]
        public long Exp { get; set; }

        [JsonProperty("actions")]
        public long Actions { get; set; }

        [JsonProperty("secs")]
        public long Secs { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("consumables")]
        public long Consumables { get; set; }

        [JsonProperty("wards")]
        public long Wards { get; set; }

        [JsonProperty("bloodlust")]
        public long Bloodlust { get; set; }

        [JsonProperty("doublekill")]
        public long Doublekill { get; set; }

        [JsonProperty("triplekill")]
        public long Triplekill { get; set; }

        [JsonProperty("quadkill")]
        public long Quadkill { get; set; }

        [JsonProperty("annihilation")]
        public long Annihilation { get; set; }

        [JsonProperty("ks3")]
        public long Ks3 { get; set; }

        [JsonProperty("ks4")]
        public long Ks4 { get; set; }

        [JsonProperty("ks5")]
        public long Ks5 { get; set; }

        [JsonProperty("ks6")]
        public long Ks6 { get; set; }

        [JsonProperty("ks7")]
        public long Ks7 { get; set; }

        [JsonProperty("ks8")]
        public long Ks8 { get; set; }

        [JsonProperty("ks9")]
        public long Ks9 { get; set; }

        [JsonProperty("ks10")]
        public long Ks10 { get; set; }

        [JsonProperty("ks15")]
        public long Ks15 { get; set; }

        [JsonProperty("smackdown")]
        public long Smackdown { get; set; }

        [JsonProperty("humiliation")]
        public long Humiliation { get; set; }

        [JsonProperty("nemesis")]
        public long Nemesis { get; set; }

        [JsonProperty("retribution")]
        public long Retribution { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("gameplaystat0")]
        public long GameplayStat0 { get; set; }

        [JsonProperty("gameplaystat1")]
        public long GameplayStat1 { get; set; }

        [JsonProperty("gameplaystat2")]
        public long GameplayStat2 { get; set; }

        [JsonProperty("gameplaystat3")]
        public long GameplayStat3 { get; set; }

        [JsonProperty("gameplaystat4")]
        public long GameplayStat4 { get; set; }

        [JsonProperty("gameplaystat5")]
        public long GameplayStat5 { get; set; }

        [JsonProperty("gameplaystat6")]
        public long GameplayStat6 { get; set; }

        [JsonProperty("gameplaystat7")]
        public long GameplayStat7 { get; set; }

        [JsonProperty("gameplaystat8")]
        public long GameplayStat8 { get; set; }

        [JsonProperty("gameplaystat9")]
        public long GameplayStat9 { get; set; }

        [JsonProperty("time_earning_exp")]
        public long TimeEarningExp { get; set; }

        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("cli_name")]
        public string CliName { get; set; }

        [JsonProperty("mdt")]
        public string Mdt { get; set; }
    }

    public class MatchSummary
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("time_played")]
        public long TimePlayed { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset? Time { get; set; }

        [JsonProperty("mname")]
        public object Mname { get; set; }

        [JsonProperty("class")]
        public object Class { get; set; }

        [JsonProperty("nm")]
        public long Nm { get; set; }

        [JsonProperty("sd")]
        public long Sd { get; set; }

        [JsonProperty("rd")]
        public long Rd { get; set; }

        [JsonProperty("dm")]
        public long Dm { get; set; }

        [JsonProperty("bd")]
        public long Bd { get; set; }

        [JsonProperty("bp")]
        public long Bp { get; set; }

        [JsonProperty("ar")]
        public long Ar { get; set; }

        [JsonProperty("cm")]
        public long Cm { get; set; }

        [JsonProperty("lp")]
        public long Lp { get; set; }

        [JsonProperty("bb")]
        public long Bb { get; set; }

        [JsonProperty("bm")]
        public long Bm { get; set; }

        [JsonProperty("km")]
        public long Km { get; set; }

        [JsonProperty("alt_pick")]
        public long AltPick { get; set; }

        [JsonProperty("shuf")]
        public long Shuf { get; set; }

        [JsonProperty("ap")]
        public long Ap { get; set; }

        [JsonProperty("br")]
        public long Br { get; set; }

        [JsonProperty("em")]
        public long Em { get; set; }

        [JsonProperty("cas")]
        public long Cas { get; set; }

        [JsonProperty("nl")]
        public long Nl { get; set; }

        [JsonProperty("no_stats")]
        public long NoStats { get; set; }

        [JsonProperty("ab")]
        public long Ab { get; set; }

        [JsonProperty("verified_only")]
        public long VerifiedOnly { get; set; }

        [JsonProperty("gated")]
        public long Gated { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("s3_url")]
        public Uri S3Url { get; set; }

        [JsonProperty("winning_team")]
        public long WinningTeam { get; set; }

        [JsonProperty("gamemode")]
        public string Gamemode { get; set; }

        [JsonProperty("mvp")]
        public long Mvp { get; set; }

        [JsonProperty("awd_mann")]
        public long AwdMann { get; set; }

        [JsonProperty("awd_mqk")]
        public long AwdMqk { get; set; }

        [JsonProperty("awd_lgks")]
        public long AwdLgks { get; set; }

        [JsonProperty("awd_msd")]
        public long AwdMsd { get; set; }

        [JsonProperty("awd_mkill")]
        public long AwdMkill { get; set; }

        [JsonProperty("awd_masst")]
        public long AwdMasst { get; set; }

        [JsonProperty("awd_ledth")]
        public long AwdLedth { get; set; }

        [JsonProperty("awd_mbdmg")]
        public long AwdMbdmg { get; set; }

        [JsonProperty("awd_mwk")]
        public long AwdMwk { get; set; }

        [JsonProperty("awd_mhdd")]
        public long AwdMhdd { get; set; }

        [JsonProperty("awd_hcs")]
        public long AwdHcs { get; set; }

        [JsonProperty("mmpoints")]
        public long Mmpoints { get; set; }
    }
}

using Newtonsoft.Json;

#nullable disable

namespace HoNSharp.Models
{
    public class CampaignStatsResponse
    {
        [JsonProperty("0")]
        public bool The0 { get; set; }

        [JsonProperty("super_id")]
        public long? SuperId { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("standing")]
        public long? Standing { get; set; }

        [JsonProperty("account_type")]
        public long? AccountType { get; set; }

        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        [JsonProperty("level")]
        public long? Level { get; set; }

        [JsonProperty("level_exp")]
        public long? LevelExp { get; set; }

        [JsonProperty("discos")]
        public long? Discos { get; set; }

        [JsonProperty("possible_discos")]
        public long? PossibleDiscos { get; set; }

        [JsonProperty("games_played")]
        public long? GamesPlayed { get; set; }

        [JsonProperty("num_bot_games_won")]
        public long? NumBotGamesWon { get; set; }

        [JsonProperty("total_games_played")]
        public long? TotalGamesPlayed { get; set; }

        [JsonProperty("total_discos")]
        public long? TotalDiscos { get; set; }

        [JsonProperty("acc_secs")]
        public long? AccSecs { get; set; }

        [JsonProperty("acc_games_played")]
        public long? AccGamesPlayed { get; set; }

        [JsonProperty("acc_discos")]
        public long? AccDiscos { get; set; }

        [JsonProperty("rnk_secs")]
        public long? RnkSecs { get; set; }

        [JsonProperty("rnk_games_played")]
        public long? RnkGamesPlayed { get; set; }

        [JsonProperty("rnk_discos")]
        public long? RnkDiscos { get; set; }

        [JsonProperty("cs_secs")]
        public long? CsSecs { get; set; }

        [JsonProperty("cs_games_played")]
        public long? CsGamesPlayed { get; set; }

        [JsonProperty("cs_discos")]
        public long? CsDiscos { get; set; }

        [JsonProperty("mid_games_played")]
        public long? MidGamesPlayed { get; set; }

        [JsonProperty("mid_discos")]
        public long? MidDiscos { get; set; }

        [JsonProperty("rift_games_played")]
        public long? RiftGamesPlayed { get; set; }

        [JsonProperty("rift_discos")]
        public long? RiftDiscos { get; set; }

        [JsonProperty("last_activity")]
        public string LastActivity { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("season")]
        public long? Season { get; set; }

        [JsonProperty("cam_games_played")]
        public long? CamGamesPlayed { get; set; }

        [JsonProperty("cam_wins")]
        public long? CamWins { get; set; }

        [JsonProperty("cam_losses")]
        public long? CamLosses { get; set; }

        [JsonProperty("cam_concedes")]
        public long? CamConcedes { get; set; }

        [JsonProperty("cam_concedevotes")]
        public long? CamConcedevotes { get; set; }

        [JsonProperty("cam_buybacks")]
        public long? CamBuybacks { get; set; }

        [JsonProperty("cam_discos")]
        public long? CamDiscos { get; set; }

        [JsonProperty("cam_kicked")]
        public long? CamKicked { get; set; }

        [JsonProperty("cam_amm_solo_rating")]
        public CamAmmSoloRating CamAmmSoloRating { get; set; }

        [JsonProperty("cam_amm_solo_count")]
        public long? CamAmmSoloCount { get; set; }

        [JsonProperty("cam_amm_solo_conf")]
        public long? CamAmmSoloConf { get; set; }

        [JsonProperty("cam_amm_solo_prov")]
        public long? CamAmmSoloProv { get; set; }

        [JsonProperty("cam_amm_solo_pset")]
        public long? CamAmmSoloPset { get; set; }

        [JsonProperty("cam_amm_team_rating")]
        public object CamAmmTeamRating { get; set; }

        [JsonProperty("cam_amm_team_count")]
        public long? CamAmmTeamCount { get; set; }

        [JsonProperty("cam_amm_team_conf")]
        public long? CamAmmTeamConf { get; set; }

        [JsonProperty("cam_amm_team_prov")]
        public long? CamAmmTeamProv { get; set; }

        [JsonProperty("cam_amm_team_pset")]
        public long? CamAmmTeamPset { get; set; }

        [JsonProperty("cam_herokills")]
        public long? CamHerokills { get; set; }

        [JsonProperty("cam_herodmg")]
        public long? CamHerodmg { get; set; }

        [JsonProperty("cam_heroexp")]
        public long? CamHeroexp { get; set; }

        [JsonProperty("cam_herokillsgold")]
        public long? CamHerokillsgold { get; set; }

        [JsonProperty("cam_heroassists")]
        public long? CamHeroassists { get; set; }

        [JsonProperty("cam_deaths")]
        public long? CamDeaths { get; set; }

        [JsonProperty("cam_goldlost2death")]
        public long? CamGoldlost2Death { get; set; }

        [JsonProperty("cam_secs_dead")]
        public long? CamSecsDead { get; set; }

        [JsonProperty("cam_teamcreepkills")]
        public long? CamTeamcreepkills { get; set; }

        [JsonProperty("cam_teamcreepdmg")]
        public long? CamTeamcreepdmg { get; set; }

        [JsonProperty("cam_teamcreepexp")]
        public long? CamTeamcreepexp { get; set; }

        [JsonProperty("cam_teamcreepgold")]
        public long? CamTeamcreepgold { get; set; }

        [JsonProperty("cam_neutralcreepkills")]
        public long? CamNeutralcreepkills { get; set; }

        [JsonProperty("cam_neutralcreepdmg")]
        public long? CamNeutralcreepdmg { get; set; }

        [JsonProperty("cam_neutralcreepexp")]
        public long? CamNeutralcreepexp { get; set; }

        [JsonProperty("cam_neutralcreepgold")]
        public long? CamNeutralcreepgold { get; set; }

        [JsonProperty("cam_bdmg")]
        public long? CamBdmg { get; set; }

        [JsonProperty("cam_bdmgexp")]
        public long? CamBdmgexp { get; set; }

        [JsonProperty("cam_razed")]
        public long? CamRazed { get; set; }

        [JsonProperty("cam_bgold")]
        public long? CamBgold { get; set; }

        [JsonProperty("cam_denies")]
        public long? CamDenies { get; set; }

        [JsonProperty("cam_exp_denied")]
        public long? CamExpDenied { get; set; }

        [JsonProperty("cam_gold")]
        public long? CamGold { get; set; }

        [JsonProperty("cam_gold_spent")]
        public long? CamGoldSpent { get; set; }

        [JsonProperty("cam_exp")]
        public long? CamExp { get; set; }

        [JsonProperty("cam_actions")]
        public long? CamActions { get; set; }

        [JsonProperty("cam_secs")]
        public long? CamSecs { get; set; }

        [JsonProperty("cam_consumables")]
        public long? CamConsumables { get; set; }

        [JsonProperty("cam_wards")]
        public long? CamWards { get; set; }

        [JsonProperty("cam_em_played")]
        public long? CamEmPlayed { get; set; }

        [JsonProperty("cam_level")]
        public long? CamLevel { get; set; }

        [JsonProperty("cam_level_exp")]
        public long? CamLevelExp { get; set; }

        [JsonProperty("cam_min_exp")]
        public long? CamMinExp { get; set; }

        [JsonProperty("cam_max_exp")]
        public long? CamMaxExp { get; set; }

        [JsonProperty("cam_time_earning_exp")]
        public long? CamTimeEarningExp { get; set; }

        [JsonProperty("cam_bloodlust")]
        public long? CamBloodlust { get; set; }

        [JsonProperty("cam_double?kill")]
        public long? Camdoublekill { get; set; }

        [JsonProperty("cam_triplekill")]
        public long? CamTriplekill { get; set; }

        [JsonProperty("cam_quadkill")]
        public long? CamQuadkill { get; set; }

        [JsonProperty("cam_annihilation")]
        public long? CamAnnihilation { get; set; }

        [JsonProperty("cam_ks3")]
        public long? CamKs3 { get; set; }

        [JsonProperty("cam_ks4")]
        public long? CamKs4 { get; set; }

        [JsonProperty("cam_ks5")]
        public long? CamKs5 { get; set; }

        [JsonProperty("cam_ks6")]
        public long? CamKs6 { get; set; }

        [JsonProperty("cam_ks7")]
        public long? CamKs7 { get; set; }

        [JsonProperty("cam_ks8")]
        public long? CamKs8 { get; set; }

        [JsonProperty("cam_ks9")]
        public long? CamKs9 { get; set; }

        [JsonProperty("cam_ks10")]
        public long? CamKs10 { get; set; }

        [JsonProperty("cam_ks15")]
        public long? CamKs15 { get; set; }

        [JsonProperty("cam_smackdown")]
        public long? CamSmackdown { get; set; }

        [JsonProperty("cam_humiliation")]
        public long? CamHumiliation { get; set; }

        [JsonProperty("cam_nemesis")]
        public long? CamNemesis { get; set; }

        [JsonProperty("cam_retribution")]
        public long? CamRetribution { get; set; }

        [JsonProperty("acc_pub_skill")]
        public long? AccPubSkill { get; set; }

        [JsonProperty("acc_wins")]
        public long? AccWins { get; set; }

        [JsonProperty("acc_losses")]
        public long? AccLosses { get; set; }

        [JsonProperty("acc_concedes")]
        public long? AccConcedes { get; set; }

        [JsonProperty("acc_concedevotes")]
        public long? AccConcedevotes { get; set; }

        [JsonProperty("acc_buybacks")]
        public long? AccBuybacks { get; set; }

        [JsonProperty("acc_kicked")]
        public long? AccKicked { get; set; }

        [JsonProperty("acc_amm_solo_rating")]
        public object AccAmmSoloRating { get; set; }

        [JsonProperty("acc_amm_solo_count")]
        public long? AccAmmSoloCount { get; set; }

        [JsonProperty("acc_amm_solo_conf")]
        public long? AccAmmSoloConf { get; set; }

        [JsonProperty("acc_amm_solo_prov")]
        public long? AccAmmSoloProv { get; set; }

        [JsonProperty("acc_amm_solo_pset")]
        public long? AccAmmSoloPset { get; set; }

        [JsonProperty("acc_amm_team_rating")]
        public object AccAmmTeamRating { get; set; }

        [JsonProperty("acc_amm_team_count")]
        public long? AccAmmTeamCount { get; set; }

        [JsonProperty("acc_amm_team_conf")]
        public long? AccAmmTeamConf { get; set; }

        [JsonProperty("acc_amm_team_prov")]
        public long? AccAmmTeamProv { get; set; }

        [JsonProperty("acc_amm_team_pset")]
        public long? AccAmmTeamPset { get; set; }

        [JsonProperty("acc_herokills")]
        public long? AccHerokills { get; set; }

        [JsonProperty("acc_herodmg")]
        public long? AccHerodmg { get; set; }

        [JsonProperty("acc_heroexp")]
        public long? AccHeroexp { get; set; }

        [JsonProperty("acc_herokillsgold")]
        public long? AccHerokillsgold { get; set; }

        [JsonProperty("acc_heroassists")]
        public long? AccHeroassists { get; set; }

        [JsonProperty("acc_deaths")]
        public long? AccDeaths { get; set; }

        [JsonProperty("acc_goldlost2death")]
        public long? AccGoldlost2Death { get; set; }

        [JsonProperty("acc_secs_dead")]
        public long? AccSecsDead { get; set; }

        [JsonProperty("acc_teamcreepkills")]
        public long? AccTeamcreepkills { get; set; }

        [JsonProperty("acc_teamcreepdmg")]
        public long? AccTeamcreepdmg { get; set; }

        [JsonProperty("acc_teamcreepexp")]
        public long? AccTeamcreepexp { get; set; }

        [JsonProperty("acc_teamcreepgold")]
        public long? AccTeamcreepgold { get; set; }

        [JsonProperty("acc_neutralcreepkills")]
        public long? AccNeutralcreepkills { get; set; }

        [JsonProperty("acc_neutralcreepdmg")]
        public long? AccNeutralcreepdmg { get; set; }

        [JsonProperty("acc_neutralcreepexp")]
        public long? AccNeutralcreepexp { get; set; }

        [JsonProperty("acc_neutralcreepgold")]
        public long? AccNeutralcreepgold { get; set; }

        [JsonProperty("acc_bdmg")]
        public long? AccBdmg { get; set; }

        [JsonProperty("acc_bdmgexp")]
        public long? AccBdmgexp { get; set; }

        [JsonProperty("acc_razed")]
        public long? AccRazed { get; set; }

        [JsonProperty("acc_bgold")]
        public long? AccBgold { get; set; }

        [JsonProperty("acc_denies")]
        public long? AccDenies { get; set; }

        [JsonProperty("acc_exp_denied")]
        public long? AccExpDenied { get; set; }

        [JsonProperty("acc_gold")]
        public long? AccGold { get; set; }

        [JsonProperty("acc_gold_spent")]
        public long? AccGoldSpent { get; set; }

        [JsonProperty("acc_exp")]
        public long? AccExp { get; set; }

        [JsonProperty("acc_actions")]
        public long? AccActions { get; set; }

        [JsonProperty("acc_consumables")]
        public long? AccConsumables { get; set; }

        [JsonProperty("acc_wards")]
        public long? AccWards { get; set; }

        [JsonProperty("acc_em_played")]
        public long? AccEmPlayed { get; set; }

        [JsonProperty("acc_level")]
        public long? AccLevel { get; set; }

        [JsonProperty("acc_level_exp")]
        public long? AccLevelExp { get; set; }

        [JsonProperty("acc_min_exp")]
        public long? AccMinExp { get; set; }

        [JsonProperty("acc_max_exp")]
        public long? AccMaxExp { get; set; }

        [JsonProperty("acc_time_earning_exp")]
        public long? AccTimeEarningExp { get; set; }

        [JsonProperty("acc_bloodlust")]
        public long? AccBloodlust { get; set; }

        [JsonProperty("acc_double?kill")]
        public long? Accdoublekill { get; set; }

        [JsonProperty("acc_triplekill")]
        public long? AccTriplekill { get; set; }

        [JsonProperty("acc_quadkill")]
        public long? AccQuadkill { get; set; }

        [JsonProperty("acc_annihilation")]
        public long? AccAnnihilation { get; set; }

        [JsonProperty("acc_ks3")]
        public long? AccKs3 { get; set; }

        [JsonProperty("acc_ks4")]
        public long? AccKs4 { get; set; }

        [JsonProperty("acc_ks5")]
        public long? AccKs5 { get; set; }

        [JsonProperty("acc_ks6")]
        public long? AccKs6 { get; set; }

        [JsonProperty("acc_ks7")]
        public long? AccKs7 { get; set; }

        [JsonProperty("acc_ks8")]
        public long? AccKs8 { get; set; }

        [JsonProperty("acc_ks9")]
        public long? AccKs9 { get; set; }

        [JsonProperty("acc_ks10")]
        public long? AccKs10 { get; set; }

        [JsonProperty("acc_ks15")]
        public long? AccKs15 { get; set; }

        [JsonProperty("acc_smackdown")]
        public long? AccSmackdown { get; set; }

        [JsonProperty("acc_humiliation")]
        public long? AccHumiliation { get; set; }

        [JsonProperty("acc_nemesis")]
        public long? AccNemesis { get; set; }

        [JsonProperty("acc_retribution")]
        public long? AccRetribution { get; set; }

        [JsonProperty("cam_cs_games_played")]
        public long? CamCsGamesPlayed { get; set; }

        [JsonProperty("cam_cs_wins")]
        public long? CamCsWins { get; set; }

        [JsonProperty("cam_cs_losses")]
        public long? CamCsLosses { get; set; }

        [JsonProperty("cam_cs_concedes")]
        public long? CamCsConcedes { get; set; }

        [JsonProperty("cam_cs_concedevotes")]
        public long? CamCsConcedevotes { get; set; }

        [JsonProperty("cam_cs_buybacks")]
        public long? CamCsBuybacks { get; set; }

        [JsonProperty("cam_cs_discos")]
        public long? CamCsDiscos { get; set; }

        [JsonProperty("cam_cs_kicked")]
        public long? CamCsKicked { get; set; }

        [JsonProperty("cam_cs_amm_solo_rating")]
        public object CamCsAmmSoloRating { get; set; }

        [JsonProperty("cam_cs_amm_solo_count")]
        public long? CamCsAmmSoloCount { get; set; }

        [JsonProperty("cam_cs_amm_solo_conf")]
        public long? CamCsAmmSoloConf { get; set; }

        [JsonProperty("cam_cs_amm_solo_prov")]
        public long? CamCsAmmSoloProv { get; set; }

        [JsonProperty("cam_cs_amm_solo_pset")]
        public long? CamCsAmmSoloPset { get; set; }

        [JsonProperty("cam_cs_amm_team_rating")]
        public object CamCsAmmTeamRating { get; set; }

        [JsonProperty("cam_cs_amm_team_count")]
        public long? CamCsAmmTeamCount { get; set; }

        [JsonProperty("cam_cs_amm_team_conf")]
        public long? CamCsAmmTeamConf { get; set; }

        [JsonProperty("cam_cs_amm_team_prov")]
        public long? CamCsAmmTeamProv { get; set; }

        [JsonProperty("cam_cs_amm_team_pset")]
        public long? CamCsAmmTeamPset { get; set; }

        [JsonProperty("cam_cs_herokills")]
        public long? CamCsHerokills { get; set; }

        [JsonProperty("cam_cs_herodmg")]
        public long? CamCsHerodmg { get; set; }

        [JsonProperty("cam_cs_heroexp")]
        public long? CamCsHeroexp { get; set; }

        [JsonProperty("cam_cs_herokillsgold")]
        public long? CamCsHerokillsgold { get; set; }

        [JsonProperty("cam_cs_heroassists")]
        public long? CamCsHeroassists { get; set; }

        [JsonProperty("cam_cs_deaths")]
        public long? CamCsDeaths { get; set; }

        [JsonProperty("cam_cs_goldlost2death")]
        public long? CamCsGoldlost2Death { get; set; }

        [JsonProperty("cam_cs_secam_cs_dead")]
        public long? CamCsSecamCsDead { get; set; }

        [JsonProperty("cam_cs_teamcreepkills")]
        public long? CamCsTeamcreepkills { get; set; }

        [JsonProperty("cam_cs_teamcreepdmg")]
        public long? CamCsTeamcreepdmg { get; set; }

        [JsonProperty("cam_cs_teamcreepexp")]
        public long? CamCsTeamcreepexp { get; set; }

        [JsonProperty("cam_cs_teamcreepgold")]
        public long? CamCsTeamcreepgold { get; set; }

        [JsonProperty("cam_cs_neutralcreepkills")]
        public long? CamCsNeutralcreepkills { get; set; }

        [JsonProperty("cam_cs_neutralcreepdmg")]
        public long? CamCsNeutralcreepdmg { get; set; }

        [JsonProperty("cam_cs_neutralcreepexp")]
        public long? CamCsNeutralcreepexp { get; set; }

        [JsonProperty("cam_cs_neutralcreepgold")]
        public long? CamCsNeutralcreepgold { get; set; }

        [JsonProperty("cam_cs_bdmg")]
        public long? CamCsBdmg { get; set; }

        [JsonProperty("cam_cs_bdmgexp")]
        public long? CamCsBdmgexp { get; set; }

        [JsonProperty("cam_cs_razed")]
        public long? CamCsRazed { get; set; }

        [JsonProperty("cam_cs_bgold")]
        public long? CamCsBgold { get; set; }

        [JsonProperty("cam_cs_denies")]
        public long? CamCsDenies { get; set; }

        [JsonProperty("cam_cs_exp_denied")]
        public long? CamCsExpDenied { get; set; }

        [JsonProperty("cam_cs_gold")]
        public long? CamCsGold { get; set; }

        [JsonProperty("cam_cs_gold_spent")]
        public long? CamCsGoldSpent { get; set; }

        [JsonProperty("cam_cs_exp")]
        public long? CamCsExp { get; set; }

        [JsonProperty("cam_cs_actions")]
        public long? CamCsActions { get; set; }

        [JsonProperty("cam_cs_secs")]
        public long? CamCsSecs { get; set; }

        [JsonProperty("cam_cs_consumables")]
        public long? CamCsConsumables { get; set; }

        [JsonProperty("cam_cs_wards")]
        public long? CamCsWards { get; set; }

        [JsonProperty("cam_cs_em_played")]
        public long? CamCsEmPlayed { get; set; }

        [JsonProperty("cam_cs_level")]
        public long? CamCsLevel { get; set; }

        [JsonProperty("cam_cs_level_exp")]
        public long? CamCsLevelExp { get; set; }

        [JsonProperty("cam_cs_min_exp")]
        public long? CamCsMinExp { get; set; }

        [JsonProperty("cam_cs_max_exp")]
        public long? CamCsMaxExp { get; set; }

        [JsonProperty("cam_cs_time_earning_exp")]
        public long? CamCsTimeEarningExp { get; set; }

        [JsonProperty("cam_cs_bloodlust")]
        public long? CamCsBloodlust { get; set; }

        [JsonProperty("cam_cs_double?kill")]
        public long? CamCsdoublekill { get; set; }

        [JsonProperty("cam_cs_triplekill")]
        public long? CamCsTriplekill { get; set; }

        [JsonProperty("cam_cs_quadkill")]
        public long? CamCsQuadkill { get; set; }

        [JsonProperty("cam_cs_annihilation")]
        public long? CamCsAnnihilation { get; set; }

        [JsonProperty("cam_cs_ks3")]
        public long? CamCsKs3 { get; set; }

        [JsonProperty("cam_cs_ks4")]
        public long? CamCsKs4 { get; set; }

        [JsonProperty("cam_cs_ks5")]
        public long? CamCsKs5 { get; set; }

        [JsonProperty("cam_cs_ks6")]
        public long? CamCsKs6 { get; set; }

        [JsonProperty("cam_cs_ks7")]
        public long? CamCsKs7 { get; set; }

        [JsonProperty("cam_cs_ks8")]
        public long? CamCsKs8 { get; set; }

        [JsonProperty("cam_cs_ks9")]
        public long? CamCsKs9 { get; set; }

        [JsonProperty("cam_cs_ks10")]
        public long? CamCsKs10 { get; set; }

        [JsonProperty("cam_cs_ks15")]
        public long? CamCsKs15 { get; set; }

        [JsonProperty("cam_cs_smackdown")]
        public long? CamCsSmackdown { get; set; }

        [JsonProperty("cam_cs_humiliation")]
        public long? CamCsHumiliation { get; set; }

        [JsonProperty("cam_cs_nemesis")]
        public long? CamCsNemesis { get; set; }

        [JsonProperty("cam_cs_retribution")]
        public long? CamCsRetribution { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("favHero1")]
        public string FavHero1 { get; set; }

        [JsonProperty("favHero1Time")]
        public long? FavHero1Time { get; set; }

        [JsonProperty("favHero1_2")]
        public string FavHero12 { get; set; }

        [JsonProperty("favHero2")]
        public string FavHero2 { get; set; }

        [JsonProperty("favHero2Time")]
        public long? FavHero2Time { get; set; }

        [JsonProperty("favHero2_2")]
        public string FavHero22 { get; set; }

        [JsonProperty("favHero3")]
        public string FavHero3 { get; set; }

        [JsonProperty("favHero3Time")]
        public long? FavHero3Time { get; set; }

        [JsonProperty("favHero3_2")]
        public string FavHero32 { get; set; }

        [JsonProperty("favHero4")]
        public string FavHero4 { get; set; }

        [JsonProperty("favHero4Time")]
        public long? FavHero4Time { get; set; }

        [JsonProperty("favHero4_2")]
        public string FavHero42 { get; set; }

        [JsonProperty("favHero5")]
        public string FavHero5 { get; set; }

        [JsonProperty("favHero5Time")]
        public long? FavHero5Time { get; set; }

        [JsonProperty("favHero5_2")]
        public string FavHero52 { get; set; }

        [JsonProperty("dice_tokens")]
        public long? DiceTokens { get; set; }

        [JsonProperty("season_level")]
        public long? SeasonLevel { get; set; }

        [JsonProperty("slot_id")]
        public long? SlotId { get; set; }

        [JsonProperty("my_upgrades")]
        public Dictionary<string, string> MyUpgrades { get; set; }

        [JsonProperty("selected_upgrades")]
        public Dictionary<string, string> SelectedUpgrades { get; set; }

        [JsonProperty("game_tokens")]
        public long? GameTokens { get; set; }

        [JsonProperty("my_upgrades_info")]
        public MyUpgradesInfo MyUpgradesInfo { get; set; }

        [JsonProperty("creep_level")]
        public long? CreepLevel { get; set; }

        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("matchIds")]
        public string MatchIds { get; set; }

        [JsonProperty("matchDates")]
        public string MatchDates { get; set; }

        [JsonProperty("k_d_a")]
        public string KDA { get; set; }

        [JsonProperty("avgGameLength")]
        public double? AvgGameLength { get; set; }

        [JsonProperty("avgXP_min")]
        public double? AvgXpMin { get; set; }

        [JsonProperty("avgDenies")]
        public double? AvgDenies { get; set; }

        [JsonProperty("avgCreepKills")]
        public double? AvgCreepKills { get; set; }

        [JsonProperty("avgNeutralKills")]
        public double? AvgNeutralKills { get; set; }

        [JsonProperty("avgActions_min")]
        public double? AvgActionsMin { get; set; }

        [JsonProperty("avgWardsUsed")]
        public double? AvgWardsUsed { get; set; }

        [JsonProperty("quest_stats")]
        public QuestStats QuestStats { get; set; }

        [JsonProperty("highest_level_current")]
        public long? HighestLevelCurrent { get; set; }

        [JsonProperty("current_level")]
        public long? CurrentLevel { get; set; }

        [JsonProperty("level_percent")]
        public long? LevelPercent { get; set; }

        [JsonProperty("season_id")]
        public long? SeasonId { get; set; }

        [JsonProperty("prev_seasons_cam_games_played")]
        public long? PrevSeasonsCamGamesPlayed { get; set; }

        [JsonProperty("prev_seasons_cam_discos")]
        public long? PrevSeasonsCamDiscos { get; set; }

        [JsonProperty("latest_season_cam_games_played")]
        public long? LatestSeasonCamGamesPlayed { get; set; }

        [JsonProperty("latest_season_cam_discos")]
        public long? LatestSeasonCamDiscos { get; set; }

        [JsonProperty("curr_season_cam_games_played")]
        public long? CurrSeasonCamGamesPlayed { get; set; }

        [JsonProperty("curr_season_cam_discos")]
        public long? CurrSeasonCamDiscos { get; set; }

        [JsonProperty("prev_seasons_cam_cs_games_played")]
        public long? PrevSeasonsCamCsGamesPlayed { get; set; }

        [JsonProperty("prev_seasons_cam_cs_discos")]
        public long? PrevSeasonsCamCsDiscos { get; set; }

        [JsonProperty("latest_season_cam_cs_games_played")]
        public long? LatestSeasonCamCsGamesPlayed { get; set; }

        [JsonProperty("latest_season_cam_cs_discos")]
        public long? LatestSeasonCamCsDiscos { get; set; }

        [JsonProperty("curr_season_cam_cs_games_played")]
        public long? CurrSeasonCamCsGamesPlayed { get; set; }

        [JsonProperty("curr_season_cam_cs_discos")]
        public long? CurrSeasonCamCsDiscos { get; set; }

        [JsonProperty("con_reward")]
        public ConReward ConReward { get; set; }

        [JsonProperty("vested_threshold")]
        public long? VestedThreshold { get; set; }
    }

    public class CamAmmSoloRating
    {
        [JsonProperty("MinValue")]
        public CamAmmSoloRating MinValue { get; set; }

        [JsonProperty("Epsilon")]
        public CamAmmSoloRating Epsilon { get; set; }

        [JsonProperty("MaxValue")]
        public CamAmmSoloRating MaxValue { get; set; }

        [JsonProperty("PositiveInfinity")]
        public CamAmmSoloRating PositiveInfinity { get; set; }

        [JsonProperty("NegativeInfinity")]
        public CamAmmSoloRating NegativeInfinity { get; set; }

        [JsonProperty("NaN")]
        public CamAmmSoloRating NaN { get; set; }
    }

    public class ConReward
    {
        [JsonProperty("old_lvl")]
        public long? OldLvl { get; set; }

        [JsonProperty("curr_lvl")]
        public long? CurrLvl { get; set; }

        [JsonProperty("next_lvl")]
        public long? NextLvl { get; set; }

        [JsonProperty("require_rank")]
        public long? RequireRank { get; set; }

        [JsonProperty("need_more_play")]
        public long? NeedMorePlay { get; set; }

        [JsonProperty("percentage_before")]
        public string PercentageBefore { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }
    }

    public class MyUpgradesInfo
    {
    }

    public class QuestStats
    {
        [JsonProperty("error")]
        public Error Error { get; set; }
    }

    public class Error
    {
        [JsonProperty("quest_status")]
        public long? QuestStatus { get; set; }

        [JsonProperty("leaderboard_status")]
        public long? LeaderboardStatus { get; set; }
    }
}

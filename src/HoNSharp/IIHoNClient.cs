using HoNSharp.Models;
using HoNSharp.Models.Enums;

namespace HoNSharp
{
    public interface IIHoNClient : IDisposable
    {
        /// <summary>
        /// Get detailed match stats.
        /// </summary>
        /// <param name="matchId">Match Id.</param>
        Task<Response<MatchStatsResponse>> GetMatchStatsAsync(string matchId);

        /// <summary>
        /// Get player match history overview.
        /// 
        /// Result data is formatted in the following format:
        /// 
        /// <para>
        /// Match Id, Win (1)/Lose(0), Legion(1)/Hellbourne(2), Kills, Deaths, Assists, 4294967295, Match duration (in seconds), Map, Time, Hero
        /// </para>
        /// <para>
        /// Example: 520460,1,2,1,1,1,4294967295,1200,caldavar,11/9/2022,Hero_Geomancer
        /// </para>
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        /// <param name="map">Map.</param>
        Task<Response<Dictionary<string, string>>> GetMatchHistoryOverviewAsync(string nickname, Map map);

        /// <summary>
        /// Get campaign stats for the player.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        /// <param name="map">Map.</param>
        Task<Response<CampaignStatsResponse>> GetCampaignStatsAsync(string nickname, Map map);

        /// <summary>
        /// Get mastery stats for the player.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        Task<Response<MasteryStatsResponse>> GetMasteryStatsAsync(string nickname);

        /// <summary>
        /// Get simple player stats.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        Task<Response<SimpleStatsResponse>> GetSimpleStatsAsync(string nickname);

        /// <summary>
        /// Get the player's last played matches.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        Task<Response<LastPlayerMatchesResponse>> GetLastPlayerMatchesAsync(string nickname);

        /// <summary>
        /// Get stats for all heroes.
        /// </summary>
        Task<Response<AllHeroStatsResponse>> GetAllHeroStatsAsync();
    }
}

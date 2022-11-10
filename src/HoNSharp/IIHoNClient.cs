using HoNSharp.Models;

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
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        Task<Response<Dictionary<string, string>>> GetMatchHistoryOverviewAsync(string nickname);

        /// <summary>
        /// Get campaign stats for the player.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        Task<Response<CampaignStatsResponse>> GetCampaignStatsAsync(string nickname);

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

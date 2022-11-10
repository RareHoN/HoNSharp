using Newtonsoft.Json;
using HoNSharp.Models;
using HoNSharp.Converters;

#nullable disable

namespace HoNSharp
{
    public class HoNClient : IIHoNClient
    {
        private readonly HttpClient _httpClient;
        private readonly PhPToJsonConverter _phpToJsonConverter;
        private readonly string _cookie;

        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="HoNClient"/> class.
        /// </summary>
        /// <param name="cookie">HoN cookie. Can be empty for now.</param>
        public HoNClient(string cookie = null)
        {
            // NOTE: cookie is currently not needed for the requests
            // TODO: add this check back
            // if (string.IsNullOrWhiteSpace(cookie))
            // {
            //     throw new ArgumentNullException(nameof(cookie));
            // }
            // 
            // if (cookie.Length != 32)
            // {
            //     throw new ArgumentException($"Cookie length must be 32. Provided cookie length: {cookie.Length}");
            // }

            _httpClient = new HttpClient { BaseAddress = new Uri("https://api.kongor.online") };
            _phpToJsonConverter = new PhPToJsonConverter();
            _cookie = cookie;
        }

        /// <summary>
        /// Get detailed match stats.
        /// </summary>
        /// <param name="matchId">Match Id.</param>
        public async Task<Response<MatchStatsResponse>> GetMatchStatsAsync(string matchId)
        {
            return await PostAsync<MatchStatsResponse>(
                "/client_requester.php?f=get_match_stats",
                new Dictionary<string, string>
                {
                    { "match_id", matchId },
                    { "cookie", _cookie }
                });
        }

        /// <summary>
        /// Get player match history overview.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        public async Task<Response<Dictionary<string, string>>> GetMatchHistoryOverviewAsync(string nickname)
        {
            return await PostAsync<Dictionary<string, string>>(
                "/client_requester.php",
                new Dictionary<string, string>
                {
                    { "f", "match_history_overview" },
                    { "nickname", nickname },
                    { "table", "midwars" },
                    { "cookie", _cookie }
                });
        }

        /// <summary>
        /// Get campaign stats for the player.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        public async Task<Response<CampaignStatsResponse>> GetCampaignStatsAsync(string nickname)
        {
            return await PostAsync<CampaignStatsResponse>(
                "/client_requester.php",
                new Dictionary<string, string>
                {
                    { "f", "show_stats" },
                    { "nickname", nickname },
                    { "table", "campaign" },
                    { "cookie", _cookie }
                });
        }

        /// <summary>
        /// Get mastery stats for the player.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        public async Task<Response<MasteryStatsResponse>> GetMasteryStatsAsync(string nickname)
        {
            return await PostAsync<MasteryStatsResponse>(
                "/client_requester.php",
                new Dictionary<string, string>
                {
                    { "f", "show_stats" },
                    { "nickname", nickname },
                    { "table", "mastery" },
                    { "cookie", _cookie }
                });
        }

        /// <summary>
        /// Get simple player stats.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        public async Task<Response<SimpleStatsResponse>> GetSimpleStatsAsync(string nickname)
        {
            return await PostAsync<SimpleStatsResponse>(
                "/client_requester.php?f=show_simple_stats",
                new Dictionary<string, string>
                {
                    { "nickname", nickname },
                    { "cookie", _cookie }
                });
        }

        /// <summary>
        /// Get the player's last played matches.
        /// </summary>
        /// <param name="nickname">Player nickname.</param>
        public async Task<Response<LastPlayerMatchesResponse>> GetLastPlayerMatchesAsync(string nickname)
        {
            return await PostAsync<LastPlayerMatchesResponse>(
                "/client_requester.php",
                new Dictionary<string, string>
                {
                    { "f", "grab_last_matches_from_nick" },
                    { "nickname", nickname },
                    { "hosttime", "0" },
                    { "cookie", _cookie }
                });
        }

        /// <summary>
        /// Get stats for all heroes.
        /// </summary>
        public async Task<Response<AllHeroStatsResponse>> GetAllHeroStatsAsync()
        {
            return await PostAsync<AllHeroStatsResponse>(
                "/client_requester.php?f=get_account_all_hero_stats",
                new Dictionary<string, string>
                {
                    { "cookie", _cookie }
                });
        }

        private async Task<Response<T>> PostAsync<T>(string uri, Dictionary<string, string> body)
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, uri);

            request.Content = new FormUrlEncodedContent(body);

            var response = await _httpClient.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return new Response<T>
                {
                    IsSuccess = false,
                    StatusCode = response.StatusCode,
                    ErrorMessage = content
                };
            }

            return new Response<T>
            {
                IsSuccess = true,
                StatusCode = response.StatusCode,
                Content = DeserializeContent<T>(content)
            };
        }

        #region Private methods & IDisposable

        private T DeserializeContent<T>(string content)
        {
            var jsonContent = _phpToJsonConverter.ConvertToJson(content);

            return JsonConvert.DeserializeObject<T>(jsonContent);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _httpClient.Dispose();
                }

                disposedValue = true;
            }
        }

        #endregion
    }
}
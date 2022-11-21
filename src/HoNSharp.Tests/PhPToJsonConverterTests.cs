using ApprovalTests;
using ApprovalTests.Reporters;
using Newtonsoft.Json;
using HoNSharp.Converters;
using HoNSharp.Models;

namespace HoNSharp.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class PhPToJsonConverterTests
    {
        private readonly PhPToJsonConverter _converter;

        public PhPToJsonConverterTests()
        {
            _converter = new PhPToJsonConverter();
        }

        [Fact]
        public void ConvertToJson_GetAccountAllHeroStats_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("get_account_all_hero_stats_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<AllHeroStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_GetMatchStats_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("get_match_stats_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<MatchStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_GetMatchStats_WithAnotherError_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("get_match_stats_another_error_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<MatchStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_GetMatchStats_WithDateTimeOffsetError_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("get_match_stats_datetimeoffset_error_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<MatchStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_GetMatchStats_WithUnexpectedCharacterError_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("get_match_stats_unexpected_character_error_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<MatchStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_MatchHistoryOverviewMidwars_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("match_history_overview_midwars_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
        }

        [Fact]
        public void ConvertToJson_MatchHistoryOverviewNormal_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("match_history_overview_normal_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
        }

        [Fact]
        public void ConvertToJson_MatchHistoryOverviewEmpty_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("match_history_overview_empty_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
        }

        [Fact]
        public void ConvertToJson_ShowStatsCampaign_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("show_stats_campaign_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<CampaignStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_ShowStatsCampaign_WithLongConvertError_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("show_stats_campaign_long_convert_error_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<CampaignStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_ShowStatsCampaignError_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("show_stats_campaign_error_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<CampaignStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_ShowStatsCampaignMidwars_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("show_stats_campaign_midwars_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<CampaignStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_ShowStatsMastery_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("show_stats_mastery_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<MasteryStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_SimpleStats_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("simple_stats_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<SimpleStatsResponse>(result);
        }

        [Fact]
        public void ConvertToJson_PlayerAwardSumm_ShouldCorrectlyConvert()
        {
            // Arrange
            var responseFileContent = ReadFile("get_player_award_summ_response.txt");

            // Act
            var result = _converter.ConvertToJson(responseFileContent);

            // Assert
            Approvals.Verify(FormatJson(result));

            _ = JsonConvert.DeserializeObject<AwardSummaryResponse>(result);
        }

        private string ReadFile(string responseFileName)
        {
            var responseFilePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", responseFileName);

            return File.ReadAllText(responseFilePath);
        }

        private string FormatJson(string json)
        {
            var deserialized = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(deserialized, Formatting.Indented);
        }
    }
}
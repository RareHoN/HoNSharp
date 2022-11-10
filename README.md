# HoNSharp

An API library to communicate with api.kongor.online.

## Available methods

* `GetMatchStatsAsync`
* `GetMatchHistoryOverviewAsync`
* `GetCampaignStatsAsync`
* `GetMasteryStatsAsync`
* `GetSimpleStatsAsync`
* `GetLastPlayerMatchesAsync`
* `GetAllHeroStatsAsync`

## Example

```csharp
var honClient = new HoNClient("<HoN Cookie>");

var simplePlayerStats = await honClient.GetSimpleStatsAsync("RareHoN");

var matchHistory = await honClient.GetMatchHistoryOverviewAsync("RareHoN");
```

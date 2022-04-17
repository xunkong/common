// Test method and NativeAOT

using Xunkong.Hoyolab;
using Xunkong.Hoyolab.Wishlog;

var cookie = Environment.GetEnvironmentVariable("HoyolabCookie");
Console.WriteLine("Cookie is:");
Console.WriteLine(cookie);
var client = new HoyolabClient();
var user = await client.GetHoyolabUserInfoAsync(cookie);
Console.WriteLine(user.Nickname);
var roles = await client.GetGenshinRoleInfosAsync(cookie);
Console.WriteLine(roles.Count);
var role = roles[0];
Console.WriteLine(role.Nickname);
var sig = await client.GetSignInInfoAsync(role);
Console.WriteLine(sig.Today);
var sign = await client.SignInAsync(role);
Console.WriteLine(sign);
var summary = await client.GetGameRecordSummaryAsync(role);
Console.WriteLine(summary.PlayerStat.ActiveDayNumber);
var details = await client.GetAvatarDetailsAsync(role);
Console.WriteLine(details.Count);
var skill = await client.GetAvatarSkillLevelAsync(role, details.FirstOrDefault()?.Id ?? 10000021);
Console.WriteLine(skill.Count);
var act = await client.GetActivitiesAsync(role);
Console.WriteLine(act.GetType());
var dailynote = await client.GetDailyNoteAsync(role);
Console.WriteLine(dailynote.Uid);
var travelNotesSummary = await client.GetTravelNotesSummaryAsync(role);
Console.WriteLine(travelNotesSummary.CurrentMonth);
var travelnotesdetail = await client.GetTravelNotesDetailAsync(role, 4, Xunkong.Hoyolab.TravelNotes.TravelNotesAwardType.Primogems);
Console.WriteLine(travelnotesdetail.List.Count);
var spirall = await client.GetSpiralAbyssInfoAsync(role, 1);
Console.WriteLine(spirall.MaxFloor);
var newsList = await client.GetNewsListAsync(Xunkong.Hoyolab.News.NewsType.Announce);
Console.WriteLine(newsList.Count);
var newsDetail = await client.GetNewsDetailAsync(newsList.FirstOrDefault()?.PostId ?? 0);
Console.WriteLine(newsDetail.Subject);

var url = await WishlogClient.GetWishlogUrlFromLogFileAsync();
var uid = await new WishlogClient().GetUidAsync(url);
Console.WriteLine(uid);

Console.WriteLine("==========");
Console.WriteLine("Test finished.");

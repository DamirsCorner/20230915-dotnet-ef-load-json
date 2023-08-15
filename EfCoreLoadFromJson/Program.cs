using EfCoreLoadFromJson;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

var context = new AchievementsDbContext();

if (!await context.Games.AnyAsync())
{
    var options = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    var json = await File.ReadAllTextAsync("achievements.json");
    var games = JsonSerializer.Deserialize<List<Game>>(json, options);

    if (games != null)
    {
        context.Games.AddRange(games);
        await context.SaveChangesAsync();
    }
}

var achievementCount = await context.Achievements.CountAsync();
var gameCount = await context.Games.CountAsync();
Console.WriteLine($"{achievementCount} achievements in {gameCount} games");

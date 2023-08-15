using Microsoft.EntityFrameworkCore;

namespace EfCoreLoadFromJson;
public class AchievementsDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Achievements;Trusted_Connection=True;")
            .UseLazyLoadingProxies();
    }

    public DbSet<Game> Games => Set<Game>();
    public DbSet<Dlc> Dlcs => Set<Dlc>();
    public DbSet<Achievement> Achievements => Set<Achievement>();
}

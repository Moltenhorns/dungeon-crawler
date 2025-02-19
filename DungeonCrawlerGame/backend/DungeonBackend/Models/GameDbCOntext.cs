using Microsoft.EntityFrameworkCore;

namespace DungeonBackend.Models 
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContext0ptions<GameDbContext> options) : base(options) {}
        public DbSet<player> Players {get;set;}
    }
}
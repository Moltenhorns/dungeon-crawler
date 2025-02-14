// Database Connection
using Microsoft.EntityFrameworkCore;
namespace DungeonBackend.Models
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(o
        public DbSet<Player> Players { get; set; } // Creates Players table
    }
}
/*Connects app to Postgre SQL*/
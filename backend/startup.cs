using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DungeonBackend.Models;
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<GameDbContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection
    services.AddControllers();
}
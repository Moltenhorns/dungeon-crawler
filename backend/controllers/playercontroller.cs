// Handles API Requests 
using Microsoft.AspNetCore.Mvc;
using DungeonBackend.Models;
using System.Collections.Generic;
using System.Linq;
namespace DungeonBackend.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly GameDbContext _context;
        public PlayerController(GameDbContext context)
        {
            _context = context;
        }
        // GET: api/players
        [HttpGet]
        public ActionResult<IEnumerable<Player>> GetPlayers()
        {
            return _context.Players.ToList();
        }
        // POST: api/players
        [HttpPost]
        public ActionResult<Player> CreatePlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPlayers), new { id = player.Id },
        }
    }
}
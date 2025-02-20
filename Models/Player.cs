using System.ComponentModel.DataAnnotations;

namespace DungeonBackend.Models
{
    public class Player
    {
        [Key] // Marks this as the Primary Key in the database
        public int Id { get; set; }

        [Required] // Ensures this field must be provided
        public string Name { get; set; }

        public int HP { get; set; } = 100; // Default health
        public int XP { get; set; } = 0;   // Default XP
    }
}
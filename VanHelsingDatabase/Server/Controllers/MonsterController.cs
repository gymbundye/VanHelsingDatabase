using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace VanHelsingDatabase.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController : ControllerBase
    {
        public static List<Location> locations = new List<Location>
        {
            new Location { LocationId = 1, Name = "Translyvania"},
            new Location { LocationId = 2, Name = "Egypt" }
        };

        public static List<Monster> monsters = new List<Monster>
        {
            new Monster
            {
                Id = 1,
                FirstName ="Vlad",
                LastName ="Tepes",
                Alias = "Dracula",
                Location = locations[0]
            },
            new Monster 
            {
                Id = 2,
                FirstName = "Imhotep",
                LastName ="",
                Alias = "The Mummy",
                Location = locations[1]
            }

        };

        [HttpGet] 
        public async Task<ActionResult<List<Monster>>> GetMonsters() 
        {
            return Ok(monsters);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Monster>> GetOneMonster(int id)
        {
            var monster = monsters.FirstOrDefault(m => m.Id == id);
            if (monster == null) 
            {
                return NotFound("We haven't fought that Monster yet");
            }
            return Ok(monster);
        }

    }
}

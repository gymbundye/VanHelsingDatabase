using System.Net.Http.Json;

namespace VanHelsingDatabase.Client.Services.MonsterService
{

    public class MonsterService : IMonsterService 
    {
        private readonly HttpClient _http;
        public MonsterService(HttpClient http)
        {
            _http = http;
        }


        public List<Monster> Monsters { get; set; } = new List<Monster>();
        public List<Location> Locations { get; set; } = new List<Location>();

        public Task GetLocations()
        {
            throw new NotImplementedException();
        }

       

        public async Task<Monster> GetOneMonster(int id)
        {
            var result = await _http.GetFromJsonAsync<Monster>("api/monster/{id}");
            if (result != null)
                return result;
            throw new Exception("Monster not in Database!");
        }
        public async Task GetMonsters()
        {
            var result = await _http.GetFromJsonAsync<List<Monster>>("api/monster");
            if (result != null)
                Monsters = result;
            

        }
    }
}

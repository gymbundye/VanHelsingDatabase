namespace VanHelsingDatabase.Client.Services.MonsterService
{
    public class MonsterService : IMonsterService
    {
        public List<Monster> Monsters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Location> Locations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task GetLocations()
        {
            throw new NotImplementedException();
        }

        public Task GetMonsters()
        {
            throw new NotImplementedException();
        }

        public Task<Monster> GetOneMonster(int id)
        {
            throw new NotImplementedException();
        }
    }
}

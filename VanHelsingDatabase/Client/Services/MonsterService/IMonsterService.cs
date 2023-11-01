namespace VanHelsingDatabase.Client.Services.MonsterService
{
    public interface IMonsterService
    {
        List<Monster> Monsters { get; set;}

        List<Location> Locations {get; set;}

        Task GetLocations();

        Task GetMonsters();

        Task<Monster> GetOneMonster(int id);


    }
}

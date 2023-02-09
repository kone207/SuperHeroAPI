
namespace SuperHeroAPI.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
       List<SuperHero> GetAllHeroes();
       SuperHero? GetSingleHero(int id);
       List<SuperHero> AddHero(SuperHero hero);
       List<SuperHero>? DeleteHero(int id);
       List<SuperHero>? EditHero(int id, SuperHero request);


    }
}

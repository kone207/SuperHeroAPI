using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;
using SuperHeroAPI.Services.SuperHeroService;

namespace SuperHeroAPI.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
   public class SuperHeroController : ControllerBase
   {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }
       [HttpGet]
       public async Task<IActionResult> GetAllHeroes()
       {
            var result = _superHeroService.GetAllHeroes();
           return Ok(result);
       }

      [HttpGet]
       [Route("{id}")]
       public async Task<IActionResult> GetSingleHero(int id)
       {
            var result = _superHeroService.GetSingleHero(id);
            if (result == null)
            {
                return NotFound("ID not found");
            }
            return Ok(result);
       }

      [HttpPost]
       public async Task<IActionResult> AddHero(SuperHero hero)
       {
          var result = _superHeroService.AddHero(hero);
            return Ok(result);
       }

       [HttpDelete]
       [Route("id")]
       public async Task<IActionResult> DeleteHero([FromRoute] int id)
       {
            var result = _superHeroService.DeleteHero(id);
            if (result == null)
            {
                return NotFound("ID not found");
            }
            return Ok(result);
       }

       [HttpPut]
       [Route("{id}")]
       public async Task<IActionResult> EditHero(int id, SuperHero request)
       {
            var result = _superHeroService.EditHero(id, request);
            if(result == null)
            {
                return NotFound("ID not found");
            }
            return Ok(result);

       }

   }
}

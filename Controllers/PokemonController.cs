using System;
using Microsoft.AspNetCore.Mvc;

namespace PokedexApi.Controllers
{
    [ApiController]
    [Route("api/v1/pokemon")]
    public class PokemonController : ControllerBase
    {



        // GET api/v1/pokemon/translation/{pokemonName}
        /// <summary>
        /// Basic pokemon's Information
        /// </summary>
        /// <param name="pokemonName">Pokemon's Name</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{pokemonName}")]
        public IActionResult pokemon(string pokemonName)
        {
            return NoContent();
        }

        // GET api/v1/pokemon/translation/{pokemonName}
        /// <summary>
        /// Translated Pokemon Description based on habitat
        /// </summary>
        /// <param name="pokemonName">Pokemon's Name</param>
        /// <returns></returns>
        [HttpGet]
        [Route("translation/{pokemonName}")]
        public IActionResult pokemonTranslation(string pokemonName)
        {
            return NoContent();
        }
    }
}

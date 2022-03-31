using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokedexApi.Models;

namespace PokedexApi.PublicApi
{
    public interface IPokemonPublicApi
    {
        /// <summary>
        /// The endpoint of the api to call
        /// </summary>
        static string ApiUrl { get; }

        /// <summary>
        /// Returns pokemon's basic information
        /// </summary>
        /// <param name="pokemonName">Name of the pokemon</param>
        /// <returns></returns>
        Task<PokemonSpecies> GetPokemonAsync(string pokemonName);
    }
}

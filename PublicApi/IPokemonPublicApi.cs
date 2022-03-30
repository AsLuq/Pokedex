using System.Threading.Tasks;
using PokedexApi.Models;

namespace PokedexApi.PublicApi
{
    public interface IPokemonPublicApi
    {
        /// <summary>
        /// The endpoint of the api to call
        /// </summary>
        static string Endpoint { get; }

        /// <summary>
        /// Returns pokemon's basic information
        /// </summary>
        /// <param name="pokemonName">Name of the pokemon</param>
        /// <returns></returns>
        Task<PokemonSpecies> GetPokemonAsync(string pokemonName);
    }
}

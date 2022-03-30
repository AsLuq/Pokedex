using System.Threading.Tasks;
using PokedexApi.Models;

namespace PokedexApi.PublicApi
{
    public interface IFunnyTranslationPublicApi
    {
        /// <summary>
        /// The endpoint of the api to call
        /// </summary>
        static string Endpoint { get; }

        /// <summary>
        /// Returns pokemon's basic information with the Funny
        /// translation it's description
        /// </summary>
        /// <param name="pokemonName">Name of the pokemon</param>
        /// <returns></returns>
        Task<PokemonSpecies> GetPokemonTranslationAsync(string pokemonName);
    }
}

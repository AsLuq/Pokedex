using System.Threading.Tasks;
using Pokedex.Api.Dtos;

namespace Pokedex.Api.Clients
{
    public interface IFunnyTranslationClient
    {
        /// <summary>
        /// The endpoint of the api to call
        /// </summary>
        static string ApiUrl { get; }

        /// <summary>
        /// Returns pokemon's basic information with the Funny
        /// translation it's description
        /// </summary>
        /// <param name="pokemonName">Name of the pokemon</param>
        /// <returns></returns>
        Task<PokemonDto> GetPokemonTranslationAsync(string pokemonName);
    }
}

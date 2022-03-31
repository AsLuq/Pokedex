using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokedexApi.Dtos;

namespace PokedexApi.PublicApi
{
    public interface IFunnyTranslationPublicApi
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
        Task<PokemonTranslatedDto> GetPokemonTranslationAsync(string pokemonName);
    }
}

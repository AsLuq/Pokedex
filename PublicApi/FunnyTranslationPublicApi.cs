using System;
using System.Threading.Tasks;
using PokedexApi.Models;

namespace PokedexApi.PublicApi
{
    public class FunnyTranslationPublicApi : IFunnyTranslationPublicApi
    {
        // The endpoint of the api to call
        internal static string Endpoint { get; } = "https://api.funtranslations.com/translate/";

        //https://api.funtranslations.com/translate/yoda.json
        //https://api.funtranslations.com/translate/shakespeare.json
        //text as parameter --> ?text=kjdakak
        public async Task<PokemonSpecies> GetPokemonTranslationAsync(string pokemonName)
        {
            throw new NotImplementedException();
        }

    }
}

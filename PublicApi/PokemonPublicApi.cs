using System;
using System.Threading.Tasks;
using PokedexApi.Models;
using PokedexApi.PublicApi;

namespace PokedexApi.PublicApi
{
    public class PokemonPublicApi: IPokemonPublicApi
    {
        // The endpoint of the api to call
        internal static string Endpoint { get; } = "https://pokeapi.co/api/v2/";

        public async Task<PokemonSpecies> GetPokemonAsync(string pokemonName)
        {
            throw new NotImplementedException();
        }
    }
}

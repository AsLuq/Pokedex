using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using PokedexApi.Dtos;
using PokedexApi.Models;
using PokedexApi.Utility;

namespace PokedexApi.PublicApi
{
    public class FunnyTranslationPublicApi : IFunnyTranslationPublicApi
    {
        // The Uri of the api to call
        internal static string ApiUrl { get; } = "https://api.funtranslations.com";
        // The endpoint for the yoda translation
        private string YodaTranslationEndPoint { get; } = "/translate/yoda.json";
        // The endpoint for the Shakespear translation
        private string ShakespearTranslationEndPoint { get; } = "/translate/shakespeare.json";

        public IPokemonPublicApi _pokemonPublicApi;

        public FunnyTranslationPublicApi(IPokemonPublicApi pokemonPublicApi)
        {
            _pokemonPublicApi = pokemonPublicApi;
        }

        // GET /
        /// <summary>
        /// Returns pokemon's basic information with the Funny
        /// translation it's description
        /// </summary>
        /// <param name="pokemonName">Name of the pokemon</param>
        /// <returns></returns>
        public async Task<PokemonTranslatedDto> GetPokemonTranslationAsync(string pokemonName)
        {
            using HttpClient client = new HttpClient();
            
            // In case i want to use specific TLS protocol
            // ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //TLS 1.2

            // In case we want to add somethis in the header
            // example and authorization key
            // client.DefaultRequestHeaders.Add("key", "value");
            PokemonSpecies pokemonSpecies = await _pokemonPublicApi.GetPokemonAsync(pokemonName);

            if (pokemonSpecies == null)
                return null;

            // Read the first description of the pokemon that is not empty
            PokemonSpeciesFlavorTexts pokemonSpeciesFlavorTexts = pokemonSpecies.FlavorTextEntries
                .FirstOrDefault(x => x.FlavorText != string.Empty);

            if (pokemonSpeciesFlavorTexts == null)
                return null;

            string uri = string.Empty;

            if (pokemonSpecies.Habitat.Name == "cave" || pokemonSpecies.IsLegendary)
                uri = ApiUrl + YodaTranslationEndPoint;
            else
                uri = ApiUrl + ShakespearTranslationEndPoint;

            // addming the text to translate to the querystring
            uri += "?text=" + pokemonSpeciesFlavorTexts.FlavorText.Replace("\n", " ").Replace("\f", " ");

            HttpResponseMessage response = await client.GetAsync(requestUri: uri);

            TranslationApiResponse translationApiResponse;
            TranslationApiErrorResponse translationApiErrorResponse;

            // if response is ok convert the content to object
            if (response.IsSuccessStatusCode)
            {
                translationApiResponse = JsonConvert.DeserializeObject<TranslationApiResponse>(await response.Content.ReadAsStringAsync());
                return pokemonSpecies.AsDto(translationApiResponse.Contents.Translated);
            }
            else
            {
                translationApiErrorResponse = JsonConvert.DeserializeObject<TranslationApiErrorResponse>(await response.Content.ReadAsStringAsync());
                return pokemonSpecies.AsDto(translationApiErrorResponse);
            }

        }

    }
}

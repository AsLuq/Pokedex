using System.Linq;
using PokedexApi.Dtos;
using PokedexApi.Models;

namespace PokedexApi.Utility
{
    public static class Extensions
    {
        public static PokemonDto AsDto(this PokemonSpecies pokemon)
        {
            PokemonSpeciesFlavorTexts pokemonSpeciesFlavorTexts = pokemon.FlavorTextEntries
            .FirstOrDefault();

            return new PokemonDto
            {
                Name = pokemon.Name,
                Description = (pokemonSpeciesFlavorTexts != null) ? pokemonSpeciesFlavorTexts.FlavorText : string.Empty,
                Habitat = pokemon.Habitat.Name,
                IsLegendary = pokemon.IsLegendary
            };
        }

        public static PokemonTranslatedDto AsDto(this PokemonSpecies pokemon, string translatedDescription)
        {
            PokemonSpeciesFlavorTexts pokemonSpeciesFlavorTexts = pokemon.FlavorTextEntries
            .FirstOrDefault();

            return new PokemonTranslatedDto
            {
                Name = pokemon.Name,
                Description = translatedDescription,
                Habitat = pokemon.Habitat.Name,
                IsLegendary = pokemon.IsLegendary
            };
        }

        public static PokemonTranslatedDto AsDto(this PokemonSpecies pokemon, TranslationApiErrorResponse translationApiErrorResponse)
        {
            return new PokemonTranslatedDto
            {
                Error = translationApiErrorResponse.Error
            };
        }
    }
}

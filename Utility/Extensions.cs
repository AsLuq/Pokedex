using System.Linq;
using PokedexApi.Dtos;
using PokedexApi.Models;

namespace PokedexApi.Utility
{
    public static class Extensions
    {
        public static PokemonDto AsDto(this PokemonSpecies pokemon)
        {
            PokemonSpeciesFlavorTexts objPokemonSpeciesFlavorTexts = pokemon.FlavorTextEntries.FirstOrDefault();

            return new PokemonDto
            {
                Name = pokemon.Name,
                Description = (objPokemonSpeciesFlavorTexts != null) ? objPokemonSpeciesFlavorTexts.FlavorText : string.Empty,
                Habitat = pokemon.Habitat.Name,
                IsLegendary = pokemon.IsLegendary
            };
        }
    }
}

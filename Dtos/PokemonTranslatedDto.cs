using System;
using PokedexApi.Models;

namespace PokedexApi.Dtos
{

    public class PokemonTranslatedDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Habitat { get; set; }
        public Boolean? IsLegendary { get; set; }
        public Error Error { get; set; }

    }
}

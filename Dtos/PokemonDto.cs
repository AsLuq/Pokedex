using System;
namespace PokedexApi.Dtos
{
    public class PokemonDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Habitat { get; set; }
        public Boolean? IsLegendary { get; set; }
    }
}

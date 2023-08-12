using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
   public interface IPokemonRepository
   {
      public ICollection<Pokemon> GetPokemons();

      public Pokemon? GetPokemon(int id);

      public Pokemon? GetPokemon(string name);

      public decimal GetPokemonRatings(int id);

      public bool IsPokemonExists(int id);
   }
}

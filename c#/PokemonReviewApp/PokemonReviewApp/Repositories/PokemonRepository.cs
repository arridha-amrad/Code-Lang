using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repositories
{
   public class PokemonRepository : IPokemonRepository
   {
      private readonly DataContext _ctx;

      public PokemonRepository(DataContext ctx)
      {
         this._ctx = ctx;
      }

      public Pokemon? GetPokemon(int id)
      {
         return _ctx.Pokemons.Where(pokemon => pokemon.Id == id).FirstOrDefault();
      }

      public Pokemon? GetPokemon(string name)
      {
         return _ctx.Pokemons.Where(pokemon => pokemon.Name == name).FirstOrDefault();
      }

      public decimal GetPokemonRatings(int id)
      {
         var reviews = _ctx.Reviews.Where(r => r.Id == id);

         if (!reviews.Any())
         {
            return 0;
         }

         return reviews.Count();
      }

      public ICollection<Pokemon> GetPokemons()
      {
         return _ctx.Pokemons.OrderBy(p => p.Id).ToList();
      }

      public bool IsPokemonExists(int id)
      {
         return _ctx.Pokemons.Any(p => p.Id == id);
      }
   }
}

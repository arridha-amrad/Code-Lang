using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using PokemonReviewApp.Repositories;

namespace PokemonReviewApp.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class PokemonController : ControllerBase
   {
      private readonly IPokemonRepository _pokemonRepository;
      private readonly IMapper _mapper;

      public PokemonController(IPokemonRepository pokemonRepository, IMapper mapper)
      {
         this._pokemonRepository = pokemonRepository;
         this._mapper = mapper;
      }

      [HttpGet]
      [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
      public IActionResult GetPokemons()
      {
         var pokemons = _pokemonRepository.GetPokemons();
         var mappedPokemons = _mapper.Map<List<PokemonDTO>>(pokemons);

         if (!ModelState.IsValid)
         {
            return BadRequest(ModelState);
         }

         return Ok(mappedPokemons);
      }

      [HttpGet("{id}")]
      [ProducesResponseType(200, Type = typeof(Pokemon))]
      [ProducesResponseType(400)]
      public IActionResult GetPokemon(int id)
      {
         if (!_pokemonRepository.IsPokemonExists(id))
         {
            return NotFound("Pokemon Not Found Bossku");
         }
         var pokemon = _pokemonRepository.GetPokemon(id);
         var mappedPokemons = _mapper.Map<PokemonDTO>(pokemon);

         return Ok(mappedPokemons);
      }

      /*      [HttpGet("{name}")]
            [ProducesResponseType(200, Type = typeof(Pokemon))]
            public IActionResult GetPokemon(string name)
            {
               var pokemon = _pokemonRepository.GetPokemon(name);
               if (pokemon == null)
               {
                  return NotFound("Pokemon not found");
               }
               return Ok(pokemon);
            }*/

      [HttpGet("{id}/rating")]
      [ProducesResponseType(200, Type = typeof(Pokemon))]
      public IActionResult GetPokemonRating(int id)
      {
         if (!_pokemonRepository.IsPokemonExists(id))
         {
            return NotFound();
         }
         if (!ModelState.IsValid)
         {
            return BadRequest();
         }
         var rating = _pokemonRepository.GetPokemonRatings(id);
         return Ok(rating);

      }

   }
}

﻿using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helpers
{
   public class MappingProfile: Profile
   {
      public MappingProfile() {
         CreateMap<Pokemon, PokemonDTO>();
      }
   }
}

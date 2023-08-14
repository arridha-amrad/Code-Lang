using AutoMapper;
using LibraryApi.Dto;
using LibraryApi.Models;

namespace LibraryApi.Helpers
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<CreateUserDto, User>();
    }
  }
}
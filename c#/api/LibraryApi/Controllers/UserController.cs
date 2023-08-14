using AutoMapper;
using LibraryApi.Dto;
using LibraryApi.Interface;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private readonly IUserRepository _repo;
    private readonly IMapper _mapper;
    public UserController(IUserRepository repository, IMapper mapper)
    {
      _repo = repository;
      _mapper = mapper;
    }

    [HttpPost]
    [ProducesResponseType(201, Type = typeof(User))]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDto user)
    {
      try
      {
        var userData = _mapper.Map<CreateUserDto, User>(user);
        var response = await _repo.Create(userData);
        return Ok(response);
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return NotFound();
      }
    }
  }
}
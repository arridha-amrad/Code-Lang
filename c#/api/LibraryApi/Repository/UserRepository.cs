using LibraryApi.Data;
using LibraryApi.Interface;
using LibraryApi.Models;

namespace LibraryApi.Repository
{
  public class UserRepository : IUserRepository
  {
    private readonly AppDbContext _ctx;

    public UserRepository(AppDbContext ctx)
    {
      _ctx = ctx;
    }

    public async Task<User> Create(User user)
    {
      try
      {
        await _ctx.AddAsync(user);
        await _ctx.SaveChangesAsync();

        var newUser = _ctx.Users.Where(nu => nu.Id == user.Id).FirstOrDefault() ?? throw new Exception("new user not found");
        return newUser;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }

    }

    public void Delete(int userId)
    {
      throw new NotImplementedException();
    }

    public ICollection<User> Index()
    {
      throw new NotImplementedException();
    }

    public User? Show(int userId)
    {
      throw new NotImplementedException();
    }

    public User Update(User user)
    {
      throw new NotImplementedException();
    }
  }
}
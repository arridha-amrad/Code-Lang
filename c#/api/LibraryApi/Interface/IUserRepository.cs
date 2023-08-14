using LibraryApi.Models;

namespace LibraryApi.Interface
{
  public interface IUserRepository
  {
    public Task<User> Create(User user);

    public ICollection<User> Index();

    public void Delete(int userId);

    public User Update(User user);

    public User? Show(int userId);

  }
}
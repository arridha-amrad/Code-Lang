using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Models
{
  public class User : BaseUser
  {
    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Name
    {
      get
      {
        return $"{FirstName} {LastName}";
      }
    }
  }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApi.Models
{
  public abstract class BaseUser
  {
    public Guid Id { get; set; } = Guid.NewGuid();

    public Role Role { get; set; } = Role.Member;

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Column("JoinedAt")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

  }

  public enum Role
  {
    Admin,
    Member
  }
}
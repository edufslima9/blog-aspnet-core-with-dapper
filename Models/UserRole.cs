using Dapper.Contrib.Extensions;

namespace Blog.Models
{
  [Table("[UserRole]")]
  public class UserRole
  {
    public int UserId { get; set; }
    [Write(false)]
    public User User { get; set; }
    public int RoleId { get; set; }
    [Write(false)]
    public Role Role { get; set; }
  }
}
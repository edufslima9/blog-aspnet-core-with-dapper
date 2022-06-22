using Dapper.Contrib.Extensions;

namespace Blog.Models
{
  [Table("[PostTag]")]
  public class PostTag
  {
    public int PostId { get; set; }
    [Write(false)]
    public Post Post { get; set; }
    public int TagId { get; set; }
    [Write(false)]
    public Tag Tag { get; set; }
  }
}
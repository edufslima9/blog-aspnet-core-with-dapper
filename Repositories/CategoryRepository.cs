using Blog.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class CategoryRepository : Repository<Category>
  {
    private readonly SqlConnection _connection;

    public CategoryRepository(SqlConnection connection) : base(connection)
      => _connection = connection;

    public List<Category> GetWithCountOfPosts()
    {
      var query = @"
          SELECT
            [Category].[Name],
            COUNT([Post].[Id]) as [PostCount]
          FROM [Category]
            LEFT JOIN [Post] ON [Post].[CategoryId]=[Category].[Id]
          GROUP BY [Category].[Name]
      ";
      
      var categories = _connection.Query<Category>(query);
      return categories.ToList();
    }
  }
}
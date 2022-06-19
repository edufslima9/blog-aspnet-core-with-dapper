using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class Repository<TModel> where TModel : class
  {
    private readonly SqlConnection _connection;

    public Repository(SqlConnection connection)
      => _connection = connection;

    public IEnumerable<TModel> GetAll()
      => _connection.GetAll<TModel>();

    public TModel Get(int id)
      => _connection.Get<TModel>(id);

    public void Create(TModel item)
      =>  _connection.Insert<TModel>(item);

    public void Update(TModel item)
      => _connection.Update<TModel>(item);

    public void Delete(TModel item)
      => _connection.Delete<TModel>(item);

    public void Delete(int id)
    {
      var item = _connection.Get<TModel>(id);
      _connection.Delete<TModel>(item);
    }
  }
}
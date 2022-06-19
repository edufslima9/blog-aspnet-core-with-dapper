// See https://aka.ms/new-console-template for more information
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
  class Program
  {
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=False";

    static void Main(string[] args)
    {
      var connection = new SqlConnection(CONNECTION_STRING);
      connection.Open();

      ReadUsers(connection);
      ReadRoles(connection);
      ReadTags(connection);

      connection.Close();
    }

    public static void ReadUsers(SqlConnection connection)
    {
      var repository = new Repository<User>(connection);
      var users = repository.GetAll();

      foreach (var user in users)
        Console.WriteLine(user.Name);
    }

    public static void ReadUser(SqlConnection connection)
    {
      var repository = new Repository<User>(connection);
      var user = repository.Get(1);

      Console.WriteLine(user.Name);
    }

    public static void CreateUser(SqlConnection connection)
    {
      var user = new User()
      {
        Bio = "Equipe balta.io",
        Email = "hello@balta.io",
        Image = "https://...",
        Name = "Equipe balta.io",
        PasswordHash = "HASH",
        Slug = "equipe-balta"
      };

      var repository = new Repository<User>(connection);
      repository.Create(user);
      Console.WriteLine("Cadastro realizado com sucesso!");
    }

    public static void UpdateUser(SqlConnection connection)
    {
      var user = new User()
      {
        Id = 2,
        Bio = "Equipe | balta.io",
        Email = "hello@balta.io",
        Image = "https://...",
        Name = "Equipe de suporte balta.io",
        PasswordHash = "HASH",
        Slug = "equipe-balta"
      };

      var repository = new Repository<User>(connection);
      repository.Update(user);
      Console.WriteLine("Atualização realizada com sucesso!");
    }

    public static void DeleteUser(SqlConnection connection)
    {
      var repository = new Repository<User>(connection);
      var user = repository.Get(1);

      repository.Delete(user);
      Console.WriteLine("Exclusão realizada com sucesso!");
    }

    public static void ReadRoles(SqlConnection connection)
    {
      var repository = new Repository<Role>(connection);
      var roles = repository.GetAll();

      foreach (var role in roles)
        Console.WriteLine(role.Name);
    }

    public static void ReadTags(SqlConnection connection)
    {
      var repository = new Repository<Tag>(connection);
      var items = repository.GetAll();

      foreach (var item in items)
        Console.WriteLine(item.Name);
    }
  }
}
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
  public static class ListUsersScreen
  {
    public static void Load()
    {
      Console.WriteLine("Lista de usuários");
      Console.WriteLine("-------------");
      List();
      Console.ReadKey();
      MenuUserScreen.Load();
    }

    private static void List()
    {
      var repository = new Repository<User>(Database.connection);
      var users = repository.GetAll();

      foreach (var item in users)
      {
        Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
      }
    }
  }
}
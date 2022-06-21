using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
  public static class ListRolesScreen
  {
    public static void Load()
    {
      Console.WriteLine("Lista de perfis");
      Console.WriteLine("-------------");
      List();
      Console.ReadKey();
      MenuRoleScreen.Load();
    }

    private static void List()
    {
      var repository = new Repository<Role>(Database.connection);
      var roles = repository.GetAll();

      foreach (var item in roles)
      {
        Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
      }
    }
  }
}
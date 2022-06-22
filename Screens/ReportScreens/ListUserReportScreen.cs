using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
  public class ListUserReportScreen
  {
    public static void Load()
    {
      Console.WriteLine("Lista de usuários com perfil");
      Console.WriteLine("-------------");
      List();
      Console.ReadKey();
      MenuReportScreen.Load();
    }

    public static void List()
    {
      var repository = new UserRepository(Database.connection);
      var users = repository.GetWithRoles();

      foreach (var item in users)
      {
        var roles = new List<string>();
        foreach (var role in item.Roles)
        {
          roles.Add(role.Name);
        }
        Console.WriteLine($"{item.Name}, {item.Email} - ({String.Join(",", roles)})");
      }
    }
  }
}
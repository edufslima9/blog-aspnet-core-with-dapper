using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserRoleScreens
{
  public class CreateUserRoleScreen
  {
    public static void Load()
    {
      Console.WriteLine("Vincular perfil/usuário");
      Console.WriteLine("-------------");
      Console.Write("Id do Perfil: ");
      var userId = Console.ReadLine();
      Console.Write("Id do Usuário: ");
      var roleId = Console.ReadLine();
      Create(new UserRole {
        UserId = int.Parse(userId),
        RoleId = int.Parse(roleId)
      });
      Console.ReadKey();
    }

    public static void Create(UserRole userRole)
    {
      try
      {
        var repository = new Repository<UserRole>(Database.connection);
        repository.Create(userRole);
        Console.WriteLine("Perfil vinculado com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível o perfil ao usuário");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
  public class CreateRoleScreen
  {
    public static void Load()
    {
      Console.WriteLine("Novo perfil");
      Console.WriteLine("-------------");
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Create(new Role {
        Name = name,
        Slug = slug
      });
      Console.ReadKey();
      MenuRoleScreen.Load();
    }

    public static void Create(Role role)
    {
      try
      {
        var repository = new Repository<Role>(Database.connection);
        repository.Create(role);
        Console.WriteLine("Perfil cadastradao com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível salvar o perfil");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
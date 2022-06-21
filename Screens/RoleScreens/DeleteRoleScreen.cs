using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
  public static class DeleteRoleScreen
  {
    public static void Load()
    {
      Console.WriteLine("Excluir um perfil");
      Console.WriteLine("-------------");
      Console.Write("Qual o id do Perfil que deseja excluir? ");
      var id = Console.ReadLine();
      
      Delete(int.Parse(id));
      Console.ReadKey();
      MenuRoleScreen.Load();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Role>(Database.connection);
        repository.Delete(id);
        Console.WriteLine("Perfil exluiído com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível excluir o perfil");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
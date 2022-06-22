using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public static class DeletePostScreen
  {
    public static void Load()
    {
      Console.WriteLine("Excluir um post");
      Console.WriteLine("-------------");
      Console.Write("Qual o id do Post que deseja excluir? ");
      var id = Console.ReadLine();
      
      Delete(int.Parse(id));
      Console.ReadKey();
      MenuPostScreen.Load();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Post>(Database.connection);
        repository.Delete(id);
        Console.WriteLine("Post exluído com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível excluir o post");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
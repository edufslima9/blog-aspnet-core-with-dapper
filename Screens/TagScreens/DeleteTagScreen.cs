using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
  public static class DeleteTagScreen
  {
    public static void Load()
    {
      Console.WriteLine("Excluir uma tag");
      Console.WriteLine("-------------");
      Console.Write("Qual o id da Tag que deseja excluir? ");
      var id = Console.ReadLine();
      
      Delete(int.Parse(id));
      Console.ReadKey();
      MenuTagScreen.Load();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Tag>(Database.connection);
        repository.Delete(id);
        Console.WriteLine("Tag exluída com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível excluir a tag");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
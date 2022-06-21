using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
  public static class DeleteCategoryScreen
  {
    public static void Load()
    {
      Console.WriteLine("Excluir uma categoria");
      Console.WriteLine("-------------");
      Console.Write("Qual o id da Categoria que deseja excluir? ");
      var id = Console.ReadLine();
      
      Delete(int.Parse(id));
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Category>(Database.connection);
        repository.Delete(id);
        Console.WriteLine("Categoria exluída com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível excluir a categoria");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
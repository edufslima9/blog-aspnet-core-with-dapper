using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
  public class UpdateCategoryScreen
  {
    public static void Load()
    {
      Console.WriteLine("Atualizando uma categoria");
      Console.WriteLine("-------------");
      Console.Write("Id: ");
      var id = Console.ReadLine();
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Update(new Category {
        Id = int.Parse(id),
        Name = name,
        Slug = slug,
      });
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    public static void Update(Category category)
    {
      try
      {
        var repository = new Repository<Category>(Database.connection);
        repository.Update(category);
        Console.WriteLine("Categoria atualizada com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível atualizar a categoria");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
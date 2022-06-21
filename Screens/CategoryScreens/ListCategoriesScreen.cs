using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
  public static class ListCategoriesScreen
  {
    public static void Load()
    {
      Console.WriteLine("Lista de categorias");
      Console.WriteLine("-------------");
      List();
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    private static void List()
    {
      var repository = new Repository<Category>(Database.connection);
      var categories = repository.GetAll();

      foreach (var item in categories)
      {
        Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
      }
    }
  }
}
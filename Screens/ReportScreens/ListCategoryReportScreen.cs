using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
  public class ListCategoryReportScreen
  {
    public static void Load()
    {
      Console.WriteLine("Lista de categorias com quantidades de posts");
      Console.WriteLine("-------------");
      List();
      Console.ReadKey();
      MenuReportScreen.Load();
    }

    public static void List()
    {
      var repository = new CategoryRepository(Database.connection);
      var categories = repository.GetWithCountOfPosts();

      foreach (var item in categories)
      {
        Console.WriteLine($"{item.Name}, Posts: {item.PostCount}");
      }
    }
  }
}
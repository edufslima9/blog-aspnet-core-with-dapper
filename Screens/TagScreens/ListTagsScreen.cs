using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
  public static class ListTagsScreen
  {
    public static void Load()
    {
      Console.WriteLine("Lista de tags");
      Console.WriteLine("-------------");
      List();
      Console.ReadKey();
      MenuTagScreen.Load();
    }

    private static void List()
    {
      var repository = new Repository<Tag>(Database.connection);
      var tags = repository.GetAll();

      foreach (var item in tags)
      {
        Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
      }
    }
  }
}
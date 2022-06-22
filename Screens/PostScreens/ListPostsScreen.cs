using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public static class ListPostsScreen
  {
    public static void Load()
    {
      Console.WriteLine("Lista de posts");
      Console.WriteLine("-------------");
      List();
      Console.ReadKey();
      MenuPostScreen.Load();
    }

    private static void List()
    {
      var repository = new Repository<Post>(Database.connection);
      var posts = repository.GetAll();

      foreach (var item in posts)
      {
        Console.WriteLine($"{item.Id} - {item.Title} ({item.Slug})");
      }
    }
  }
}
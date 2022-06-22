using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostTagScreens
{
  public class CreatePostTagScreen
  {
    public static void Load()
    {
      Console.WriteLine("Vincular post/tag");
      Console.WriteLine("-------------");
      Console.Write("Id do Post: ");
      var postId = Console.ReadLine();
      Console.Write("Id da Tag: ");
      var tagId = Console.ReadLine();
      Create(new PostTag {
        PostId = int.Parse(postId),
        TagId = int.Parse(tagId)
      });
      Console.ReadKey();
    }

    public static void Create(PostTag postTag)
    {
      try
      {
        var repository = new Repository<PostTag>(Database.connection);
        repository.Create(postTag);
        Console.WriteLine("Tag vinculada com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível a tag ao post");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
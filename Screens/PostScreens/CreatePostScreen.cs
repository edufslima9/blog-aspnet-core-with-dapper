using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public class CreatePostScreen
  {
    public static void Load()
    {
      Console.WriteLine("Novo post");
      Console.WriteLine("-------------");
      Console.Write("Id da Categoria: ");
      var categoryId = Console.ReadLine();
      Console.Write("Id do Autor: ");
      var authorId = Console.ReadLine();
      Console.Write("Título: ");
      var title = Console.ReadLine();
      Console.Write("Resumo: ");
      var summary = Console.ReadLine();
      Console.Write("Corpo: ");
      var body = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Create(new Post {
        CategoryId = int.Parse(categoryId),
        AuthorId = int.Parse(authorId),
        Title = title,
        Summary = summary,
        Body = body,
        Slug = slug,
        CreateDate = DateTime.Now,
        LastUpdateDate = DateTime.Now
      });
      Console.ReadKey();
      MenuPostScreen.Load();
    }

    public static void Create(Post post)
    {
      try
      {
        var repository = new Repository<Post>(Database.connection);
        Console.WriteLine($"Post {post.CategoryId}  {post.AuthorId}");
        Console.WriteLine($"{post.Title}");
        Console.WriteLine($"{post.Summary}");
        Console.WriteLine($"{post.Body}");
        Console.WriteLine($"{post.Slug}");
        Console.WriteLine($"{post.CreateDate}");
        Console.WriteLine($"{post.LastUpdateDate}");
        repository.Create(post);
        Console.WriteLine("Post cadastrado com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível salvar o post");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
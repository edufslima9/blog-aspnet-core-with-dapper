using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public class UpdatePostScreen
  {
    public static void Load()
    {
      Console.WriteLine("Atualizando um post");
      Console.WriteLine("-------------");
      Console.Write("Id: ");
      var id = Console.ReadLine();
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
      Update(new Post {
        Id = int.Parse(id),
        CategoryId = int.Parse(categoryId),
        AuthorId = int.Parse(authorId),
        Title = title,
        Summary = summary,
        Body = body,
        Slug = slug,
        LastUpdateDate = DateTime.Now
      });
      Console.ReadKey();
      MenuPostScreen.Load();
    }

    public static void Update(Post post)
    {
      try
      {
        var repository = new Repository<Post>(Database.connection);
        var getPost = repository.Get(post.Id);
        if (getPost != null)
          post.CreateDate = getPost.CreateDate;
        else
          post.CreateDate = DateTime.Now;
        repository.Update(post);
        Console.WriteLine("Post atualizado com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível atualizar o post");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
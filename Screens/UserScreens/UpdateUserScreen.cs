using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
  public class UpdateUserScreen
  {
    public static void Load()
    {
      Console.WriteLine("Atualizando um usuário");
      Console.WriteLine("-------------");
      Console.Write("Id: ");
      var id = Console.ReadLine();
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Email: ");
      var email = Console.ReadLine();
      Console.Write("Senha: ");
      var password = Console.ReadLine();
      Console.Write("Bio: ");
      var bio = Console.ReadLine();
      Console.Write("Imagem: ");
      var image = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Update(new User {
        Id = int.Parse(id),
        Name = name,
        Email = email,
        PasswordHash = password,
        Bio = bio,
        Image = image,
        Slug = slug,
      });
      Console.ReadKey();
      MenuUserScreen.Load();
    }

    public static void Update(User user)
    {
      try
      {
        var repository = new Repository<User>(Database.connection);
        repository.Update(user);
        Console.WriteLine("Usuário atualizado com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível atualizar o usuário");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
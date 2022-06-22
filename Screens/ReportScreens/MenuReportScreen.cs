namespace Blog.Screens.ReportScreens
{
  public class MenuReportScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Relatórios");
      Console.WriteLine("-----------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Listar usuários com perfil");
      Console.WriteLine("2 - Listar categorias com quantidades de posts");
      Console.WriteLine("3 - Listar tags com quantidade de posts");
      Console.WriteLine("4 - Listar posts de uma categoria");
      Console.WriteLine("5 - Listar posts e categorias");
      Console.WriteLine("6 - Listar posts com suas tags");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine()!);

      switch (option)
      {
        case 1:
          ListUserReportScreen.Load();
          break;
        case 2:
          ListCategoryReportScreen.Load();
          break;
        /*case 3:
          UpdateRoleScreen.Load();
          break;
        case 4:
          DeleteRoleScreen.Load();
          break;
        case 5:
          DeleteRoleScreen.Load();
          break;
        case 6:
          DeleteRoleScreen.Load();
          break;*/
        default:
          Load();
          break;
      }
    }
  }
}
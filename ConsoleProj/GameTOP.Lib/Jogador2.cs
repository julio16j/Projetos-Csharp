using GameTOP.Interface;

namespace GameTOP.Lib
{
  public class Jogador2 : iJogador
  {
    public string Chuta()
    {
      return "Maradona estás pateando \n";
    }

    public string Corre()
    {
      return "Maradona estás corriendo \n";
    }

    public string Passe()
    {
      return "Maradona estás passando \n";
    }
  }
}
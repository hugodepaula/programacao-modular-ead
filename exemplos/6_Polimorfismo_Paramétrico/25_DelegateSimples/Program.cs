using System;

namespace _25_DelegateSimples
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Mensageiro.Exibir exibir = new Mensageiro.Exibir(MensagemConsole);
      
      exibir("Estou exibindo esta mensagem no console!");
    }

    public static void MensagemConsole(string mensagem)
    {
      Console.WriteLine(mensagem);
    }
  }

  public class Mensageiro
  {
    public delegate void Exibir(string mensagem);
  }
}

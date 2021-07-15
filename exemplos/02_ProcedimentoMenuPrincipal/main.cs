using System;

class MainClass 
{

  private static void Tarefa1() 
  {
    Console.Clear();
    Console.WriteLine("Executando tarefa 1.");
    Console.ReadLine();
  }

  private static void Tarefa2() 
  {
    Console.Clear();
    Console.WriteLine("Executando tarefa 2.");
    Console.ReadLine();
  }

  private static bool MenuPrincipal() 
  {
    Console.Clear();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1) Executar tarefa 1.");
    Console.WriteLine("2) Executar tarefa 2.");
    Console.WriteLine("3) Sair");
    Console.Write("\r\nOpção: ");
 
    switch (Console.ReadLine())
    {
        case "1":
            Tarefa1();
            return true;
        case "2":
            Tarefa2();
            return true;
        case "3":
            return false;
        default:
            return true;
    }
}

  public static void Main (string[] args) 
  {
     while (MenuPrincipal()) ;
  }
}
using System;
class MainClass
{

  public static void Main(string[] args)
  {
    BemDuravel bemDuravel = new BemDuravel("Notebook", 4200, 10, DateTime.Now.AddDays(-90), 12);

    Console.WriteLine("Bem Duravel:");
    Console.WriteLine(bemDuravel);

    BemDeConsumo bemDeConsumo = new BemDeConsumo("Batata frita", 11.99F, 30, DateTime.Now.AddDays(-90), DateTime.Now.AddDays(120));

    Console.WriteLine("Bem de consumo:");
    Console.WriteLine(bemDeConsumo);
  }
}

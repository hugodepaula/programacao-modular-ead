using System;

class EstendeMostra : SuperMostra
{
  public new string str = "Estende String";

  public override void mostra() 
  { 
    Console.WriteLine("---");
    Console.WriteLine("Estende mostra!");
    Console.WriteLine("---");
  }


}
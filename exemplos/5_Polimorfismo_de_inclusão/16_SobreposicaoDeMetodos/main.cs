using System;
class MainClass
{

  public static void Main(string[] args)
  {
    Console.WriteLine("");

    EstendeMostra est = new EstendeMostra();
    Console.WriteLine("este.str = {0}", est.str);
    est.mostra();

    SuperMostra sup = new SuperMostra();
    Console.WriteLine("sup.str = {0}", sup.str);
    sup.mostra();

  }
}

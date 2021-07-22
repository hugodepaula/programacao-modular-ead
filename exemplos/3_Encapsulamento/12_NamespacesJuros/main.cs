using System;
using System.Threading;

using Financeiro;
using Contabil;

class MainClass
{

  public static void Main(string[] args)
  {
    Financeiro.Juros jurosDeMora = new Financeiro.Juros();

    jurosDeMora.Valor = 120.0F;

    Contabil.Juros jurosAReceber = new Contabil.Juros();

    jurosAReceber.Valor = 231987.23F;

    Console.WriteLine($"Juros de mora: {jurosDeMora.Valor:C2}");
    Console.WriteLine($"Juros a receber: {jurosAReceber.Valor:C2}");

  }
}
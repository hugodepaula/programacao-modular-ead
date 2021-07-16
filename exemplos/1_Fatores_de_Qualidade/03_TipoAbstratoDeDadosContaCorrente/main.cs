using System;
using System.Collections.Generic;

public class Conta 
{
  private DateTime _criacao;
  private double _saldo = 0;

  public Conta(double saldoInicial, DateTime criacao) 
  {
	  _saldo = saldoInicial;
    _criacao = criacao;
  }
  
  public DateTime DataCriacao 
  {
    get { return _criacao; }
  }

  public double Sacar(double quantia) 
  {
    if (_saldo < quantia)
				throw new ArgumentException("Quantia de saque não permitida.", "quantia");
    _saldo -= quantia;
    return quantia;
  }

  public void Depositar(double quantia) 
  {
    if (quantia <= 0)
      throw new ArgumentException("Quantia de depósito não permitida.", "quantia");
    _saldo += quantia;
  }

  public double GetSaldo() 
  {
    return _saldo;
  }
}

public class MainClass 
{
  public static void Main (string[] args) 
  {
    Conta contaDoZe = new Conta(1200, DateTime.Now);

    Console.WriteLine ("Saldo da conta do Ze: {0:C2}", contaDoZe.GetSaldo());

    double quantia = 212;
    Console.WriteLine ("Sacar {0:C2} da conta do Ze.", quantia);
    contaDoZe.Sacar(quantia);

    Console.WriteLine ("Saldo da conta do Ze: {0:C2}", contaDoZe.GetSaldo());

  }
}
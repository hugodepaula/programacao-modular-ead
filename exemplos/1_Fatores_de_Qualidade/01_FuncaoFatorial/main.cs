using System;
class Calculo 
{
  public int fatorial(int n) 
  {
    int res = 1;
    if (n == 0 || n == 1) 
    {
      return res;
    }
    else if (n > 0) 
    {
      return n * fatorial(n - 1);
    }
    else 
    {
      return -1;
    }
  }
    
  static void Main(string[] args) 
  {
    int valor = 4;
    int resultado;
    Calculo calc = new Calculo();
    resultado = calc.fatorial(valor);
    Console.WriteLine("{0}! = {1}", valor, resultado);
  }
}

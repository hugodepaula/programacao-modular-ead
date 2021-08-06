using System;

namespace _26_FuncoesLambda
{
  class Program
  {
    public delegate int Soma(int x, int y);

    static void Main(string[] args)
    {
      Soma soma1 = (int x, int y) =>
      {
        int result = x + y;
        return result;
      };

      Soma soma2 = (x, y) => (x + y);

      Console.WriteLine("Soma1(2, 3) = {0}", soma1(2, 3));
      Console.WriteLine("Soma2(5, 4) = {0}", soma2(5, 4));
    }
  }
}

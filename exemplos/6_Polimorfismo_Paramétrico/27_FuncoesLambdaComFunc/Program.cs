using System;

namespace _26_FuncoesLambda
{
  class Program
  {
    static void Main(string[] args)
    {
      Func<int, int, int> soma1 = (int x, int y) =>
      {
        int result = x + y;
        return result;
      };

      Func<int, int, int> soma2 = (x, y) => (x + y);

      Console.WriteLine("Soma1(2, 3) = {0}", soma1(2, 3));
      Console.WriteLine("Soma2(5, 4) = {0}", soma2(5, 4));
    }
  }
}

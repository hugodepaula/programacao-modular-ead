using System;

namespace Generics
{
  public class Conjuntos <T> 
  {
    public static bool disjuntos(T[] s, T[] w)
    {
      for (int i = 0; i < s.Length; i++)
      {
        for (int j = 0; j < s.Length;  j++)
        {
          if (s[i].Equals(w[j]))
            return false;
        }
      }
      return true;
    } 
  }

  class MainClass {
    public static void Main(string[] args)
    {
        if (Conjuntos<int>.disjuntos(new int[] {1, 3, 5}, new int[] {2, 4, 6})) 
        {
          Console.WriteLine("Conjuntos são disjuntos");
        } else 
        {
          Console.WriteLine("Conjuntos não são disjuntos");
        }

        if (Conjuntos<double>.disjuntos(new double[] {1.7, 3.2, 5.8}, new double[] {2.4, 3.2, 6.5})) 
        {
          Console.WriteLine("Conjuntos são disjuntos");
        } else 
        {
          Console.WriteLine("Conjuntos não são disjuntos");
        }
    }
  }
}
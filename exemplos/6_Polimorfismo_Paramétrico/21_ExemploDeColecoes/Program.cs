using System;
using System.Collections.Generic;
using System.Collections;


namespace _21_ExemploDeColecoes
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
        Exemplo do uso de listas
      */
            var lista = new List<String>();
      lista.Add("Bernardo");
      lista.Add("Carolina");
      lista.Add("Felipe");
      lista.Add("Carolina");
      lista.Add("Clara");
      Console.WriteLine(string.Join(", ", lista));
      Console.WriteLine("2: " + lista[2]);
      Console.WriteLine("0: " + lista[0]);

      /*
        Exemplo do uso de filas
      */
      var fila = new Queue<String>();
      fila.Enqueue("Bernardo");
      fila.Enqueue("Carolina");
      fila.Enqueue("Felipe");
      fila.Enqueue("Elizabeth");
      fila.Enqueue("Clara");

      foreach (var nome in fila)
      {    
        Console.Write(nome + " ");
      }
      Console.WriteLine("\n");

      /*
        Exemplo do uso de pilhas
      */
      var pilha = new Stack<String>();
      pilha.Push("Bernardo");
      pilha.Push("Carolina");
      pilha.Push("Felipe");
      pilha.Push("Elizabeth");
      pilha.Push("Clara");

      foreach (var nome in pilha)
      {    
        Console.Write(nome + " ");
      }
      Console.WriteLine("\n");
    }
  }
}
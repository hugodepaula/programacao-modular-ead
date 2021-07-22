using System;
using System.Threading;

class Produto 
{
  private int id;
  private string descricao;
  private float preco;
  private int quantidade;

  private static int contador = 0;
  private static int instancias = 0;

  public Produto(String descricao, float preco, int quantidade) 
  {
    Produto.instancias++;
    this.id = ++Produto.contador;

    if (descricao.Length >= 3)
      this.descricao = descricao;
    if (preco > 0)
      this.preco = preco;
    if (quantidade >= 0)
      this.quantidade = quantidade;
  }

  public Produto() 
  {
    Produto.instancias++;
    this.id = ++Produto.contador;
    this.descricao = "Novo Produto";
    this.preco = 0.01F;
    this.quantidade = 0;
  }

  ~Produto() 
  {
      Console.WriteLine("Executando o destrutor...");
      Produto.instancias--;
  }

  public bool emEstoque() 
  {
    return (quantidade > 0);
  }
}

class MainClass 
{

  public static void Main (string[] args) 
  {
    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);

    Produto produto1 = new Produto();
    Console.WriteLine ("Construído o Produto {0}: construtor default", produto1.id);

    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);

    Produto produto2 = new Produto("Leite", 3.59F, 12);
    Console.WriteLine ("Construindo o Produto {0}: construtor com parâmetros", produto2.id);

    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);

    produto1 = null;
    Console.WriteLine("Referência para Produto 1 recebe valor null");
    
    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);

    GC.Collect();
    GC.WaitForPendingFinalizers();

    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);


  }
}
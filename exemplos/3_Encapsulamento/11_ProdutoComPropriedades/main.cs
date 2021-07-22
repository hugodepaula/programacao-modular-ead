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

  public static int Contador { get => Produto.contador; }

  public static int Instancias { get => Produto.instancias; }

  public int Id { get => id; }

  public string Descricao {
    get => this.descricao; 
    set { if (value.Length >= 3) this.descricao = value; }
  }
  public float Preco {
    get => preco;
    set { if (value > 0) this.preco = value; }
  }
  public int Quantidade { 
    get => this.quantidade;
    set { if (value >= 0) this.quantidade = value; }
  }

  public Produto(String descricao, float preco, int quantidade)
  {
    Produto.instancias++;
    this.id = ++Produto.contador;
    this.Descricao = descricao;
    this.Preco = preco;
    this.Quantidade = quantidade;
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

  public static void Main(string[] args)
  {
    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.Contador);

    Produto produto1 = new Produto();

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.Contador);

    Console.WriteLine("Produto 1: construtor default");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", produto1.Id);
    Console.WriteLine("     Descrição: {0}", produto1.Descricao);
    Console.WriteLine("         Preço: {0}", produto1.Preco);
    Console.WriteLine("    Quantidade: {0}", produto1.Quantidade);
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (produto1.emEstoque() ? "sim" : "não"));


    Produto produto2 = new Produto("Leite", 3.59F, 12);

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.Contador);

    Console.WriteLine("Produto 2: construtor com parâmetros");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", produto2.Id);
    Console.WriteLine("     Descrição: {0}", produto2.Descricao);
    Console.WriteLine("         Preço: {0}", produto2.Preco);
    Console.WriteLine("    Quantidade: {0}", produto2.Quantidade);
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (produto2.emEstoque() ? "sim" : "não"));
  }
}
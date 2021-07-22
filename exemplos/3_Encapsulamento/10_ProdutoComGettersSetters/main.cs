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

  public static int GetContador() 
  {
    return contador;
  }

  public int GetId()
  {
    return this.id;
  }

  public static int GetInstancias()
  {
    return instancias;
  }

  public string GetDescricao()
  {
    return this.descricao;
  }

  public void SetDescricao(string descricao) 
  {
    if (descricao.Length >= 3)
    {
      this.descricao = descricao;
    }
  }

  public float GetPreco()
  {
    return preco;
  }

  public void SetPreco(float preco)
  {
    if (preco > 0)
    {
      this.preco = preco;
    }
  }

  public int GetQuantidade() 
  {
    return this.quantidade;
  }

  public void SetQuantidade(int quantidade) 
  {
    if (quantidade >= 0)
    {
      this.quantidade = quantidade;
    }
  }


  public Produto(String descricao, float preco, int quantidade)
  {
    Produto.instancias++;
    this.id = ++Produto.contador;
    this.SetDescricao(descricao);
    this.SetPreco(preco);
    this.SetQuantidade(quantidade);
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
    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.GetContador());

    Produto produto1 = new Produto();

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.GetContador());

    Console.WriteLine("Produto 1: construtor default");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", produto1.GetId());
    Console.WriteLine("     Descrição: {0}", produto1.GetDescricao());
    Console.WriteLine("         Preço: {0}", produto1.GetPreco());
    Console.WriteLine("    Quantidade: {0}", produto1.GetQuantidade());
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (produto1.emEstoque() ? "sim" : "não"));


    Produto produto2 = new Produto("Leite", 3.59F, 12);

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.GetContador());

    Console.WriteLine("Produto 2: construtor com parâmetros");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", produto2.GetId());
    Console.WriteLine("     Descrição: {0}", produto2.GetDescricao());
    Console.WriteLine("         Preço: {0}", produto2.GetPreco());
    Console.WriteLine("    Quantidade: {0}", produto2.GetQuantidade());
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (produto2.emEstoque() ? "sim" : "não"));
  }
}
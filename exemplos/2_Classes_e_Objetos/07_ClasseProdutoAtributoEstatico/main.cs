using System;

class Produto 
{
  public int id;
  public string descricao;
  public float preco;
  public int quantidade;

  public static int contador;

  public Produto(String descricao, float preco, int quantidade) 
  {
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
    this.id = ++Produto.contador;
    this.descricao = "Novo Produto";
    this.preco = 0.01F;
    this.quantidade = 0;
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
    Console.WriteLine ("-\nContador de produtos: {0}\n-", Produto.contador);

    Produto produto1 = new Produto();

    Console.WriteLine ("-\nContador de produtos: {0}\n-", Produto.contador);

    Console.WriteLine ("Produto 1: construtor default");
    Console.WriteLine ("  Atributos:");
    Console.WriteLine ("            Id: {0}", produto1.id);
    Console.WriteLine ("     Descrição: {0}", produto1.descricao);
    Console.WriteLine ("         Preço: {0}", produto1.preco);
    Console.WriteLine ("    Quantidade: {0}", produto1.quantidade);
    Console.WriteLine ("  Métodos:");
    Console.WriteLine ("    Em estoque: {0}", (produto1.emEstoque() ? "sim" : "não"));


    Produto produto2 = new Produto("Leite", 3.59F, 12);

    Console.WriteLine ("-\nContador de produtos: {0}\n-", Produto.contador);

    Console.WriteLine ("Produto 2: construtor com parâmetros");
    Console.WriteLine ("  Atributos:");
    Console.WriteLine ("            Id: {0}", produto2.id);
    Console.WriteLine ("     Descrição: {0}", produto2.descricao);
    Console.WriteLine ("         Preço: {0}", produto2.preco);
    Console.WriteLine ("    Quantidade: {0}", produto2.quantidade);
    Console.WriteLine ("  Métodos:");
    Console.WriteLine ("    Em estoque: {0}", (produto2.emEstoque() ? "sim" : "não"));
  }
}
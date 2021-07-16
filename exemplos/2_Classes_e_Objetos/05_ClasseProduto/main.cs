using System;

class Produto 
{
  public string descricao;
  public float preco;
  public int quantidade;

  public bool emEstoque() 
  {
    return (quantidade > 0);
  }
}

class MainClass 
{

  public static void Main (string[] args) 
  {

    Produto produto = new Produto();

    produto.descricao = "Leite";
    produto.preco = 3.59F;
    produto.quantidade = 12;

    Console.WriteLine ("Produto:");
    Console.WriteLine ("  Atributos:");
    Console.WriteLine ("     Descrição: {0}", produto.descricao);
    Console.WriteLine ("         Preço: {0}", produto.preco);
    Console.WriteLine ("    Quantidade: {0}", produto.quantidade);
    Console.WriteLine ("  Métodos:");
    Console.WriteLine ("    Em estoque: {0}", (produto.emEstoque() ? "sim" : "não"));
  }
}
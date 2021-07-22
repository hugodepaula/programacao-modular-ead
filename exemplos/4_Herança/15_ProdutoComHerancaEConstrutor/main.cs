using System;
class MainClass
{

  public static void Main(string[] args)
  {
    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.Contador);

    BemDuravel bemDuravel = new BemDuravel("Notebook", 4200, 10, 12);

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.Contador);

    Console.WriteLine("Bem Duravel:");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", bemDuravel.Id);
    Console.WriteLine("     Descrição: {0}", bemDuravel.Descricao);
    Console.WriteLine("         Preço: {0}", bemDuravel.Preco);
    Console.WriteLine("    Quantidade: {0}", bemDuravel.Quantidade);
    Console.WriteLine("      Garantia: {0}", bemDuravel.Garantia);
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (bemDuravel.emEstoque() ? "sim" : "não"));


    BemDeConsumo bemDeConsumo = new BemDeConsumo("Batata frita", 11.99F, 30, DateTime.Now.AddDays(120));

    Console.WriteLine("-\nContador de produtos: {0}\n-", Produto.Contador);

    Console.WriteLine("Produto 2: construtor com parâmetros");
    Console.WriteLine("  Atributos:");
    Console.WriteLine("            Id: {0}", bemDeConsumo.Id);
    Console.WriteLine("     Descrição: {0}", bemDeConsumo.Descricao);
    Console.WriteLine("         Preço: {0}", bemDeConsumo.Preco);
    Console.WriteLine("    Quantidade: {0}", bemDeConsumo.Quantidade);
    Console.WriteLine("      Validade: {0}", bemDeConsumo.Validade);
    Console.WriteLine("  Métodos:");
    Console.WriteLine("    Em estoque: {0}", (bemDeConsumo.emEstoque() ? "sim" : "não"));
  }
}

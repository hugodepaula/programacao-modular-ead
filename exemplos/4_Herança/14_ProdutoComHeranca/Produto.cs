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


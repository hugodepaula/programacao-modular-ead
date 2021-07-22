using System;
using System.Threading;

class Produto
{
  private int id;
  private string descricao;
  private float preco;
  private int quantidade;
  private DateTime fabricacao;

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

  public DateTime Fabricacao
  {
    get => this.fabricacao;
    set => this.fabricacao = (value < DateTime.Now) ? value : DateTime.Now;
  }

  public Produto(string descricao, float preco, int quantidade, DateTime fabricacao)
  {
    Produto.instancias++;
    this.id = ++Produto.contador;
    this.Descricao = descricao;
    this.Preco = preco;
    this.Quantidade = quantidade;
    this.Fabricacao = fabricacao;
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
    Produto.instancias--;
  }

  public bool emEstoque()
  {
    return (quantidade > 0);
  }


  public override string ToString()
  {
    return $"Produto {id}: {descricao}   Preço: {preco:C2}   Quant.: {quantidade} Fabricação:  {fabricacao}";
  }
}


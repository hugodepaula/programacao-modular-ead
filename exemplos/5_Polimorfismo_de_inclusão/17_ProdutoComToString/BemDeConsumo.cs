using System;
class BemDeConsumo : Produto
{
  private DateTime validade;

  public DateTime Validade { 
    get => this.validade; 
    set => this.validade = (value > DateTime.Now) ? value : DateTime.Now;
  }

  public BemDeConsumo(string descricao, float preco, int quantidade, DateTime fabricacao, DateTime validade) : base(descricao, preco, quantidade, fabricacao)
  {
    this.validade = validade;
  }

  public override string ToString()
  {
    return base.ToString() + $"   Validade:  {validade}";
  }

}
using System;
class BemDeConsumo : Produto
{
  private DateTime validade;

  public DateTime Validade { 
    get => this.validade; 
    set => this.validade = (value > DateTime.Now) ? value : DateTime.Now;
  }

  public BemDeConsumo(string descricao, float preco, int quantidade, DateTime validade) : base(descricao, preco, quantidade)
  {
    this.validade = validade;
  }


}
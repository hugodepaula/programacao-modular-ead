using System;
class BemDuravel : Produto
{
  private int garantia;
  public int Garantia {
    get => this.garantia;
    set => this.garantia = (value > 0) ? value : 6;
  }

  public BemDuravel(string descricao, float preco, int quantidade, DateTime fabricacao, int garantia) : base(descricao, preco, quantidade, fabricacao)
  {
    this.Garantia = garantia;
  }

  public override string ToString()
  {
    return base.ToString() + $"  Garantia:  {garantia}";
  }

}
class BemDuravel : Produto
{
  private int garantia;
  public int Garantia {
    get => this.garantia;
    set => this.garantia = (value > 0) ? value : 6;
  }

}
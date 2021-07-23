using System.Drawing;
public abstract class Figura 
{
  public int X { get; set; }
  public int Y { get; set; }
  public int Lado { get; set; }
  public Color Cor { get; set; }
  public bool Preenchido { get; set; }

  public Figura(int x, int y, int lado, Color cor, bool preenchido) 
  {
    this.X = x;
    this.Y = y;
    this.Lado = lado;
    this.Cor = cor;
    this.Preenchido = preenchido;
  }

  // Método abstrado não possui implementação
  public abstract void Desenha();

}
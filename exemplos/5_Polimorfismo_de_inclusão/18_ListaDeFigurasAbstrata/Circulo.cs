using System;
using System.Drawing;

class Circulo : Figura
{
  public Circulo(int x, int y, int lado, Color cor, bool preenchido) : base(x, y, lado, cor, preenchido)
  {

  }

  public override void Desenha()
  {
    Console.WriteLine($"Desenhando um circulo na posição ({X},{Y}), com tamanho {Lado} a cor {Cor}.");
  }
}
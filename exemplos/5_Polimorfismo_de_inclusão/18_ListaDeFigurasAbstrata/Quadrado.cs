using System;
using System.Drawing;

class Quadrado : Figura
{
  public Quadrado(int x, int y, int lado, Color cor, bool preenchido) : base(x, y, lado, cor, preenchido)
  {
    
  }

  public override void Desenha()
  {
    Console.WriteLine($"Desenhando um quadrado na posição ({X},{Y}), com tamanho {Lado} a cor {Cor}.");
  }
}
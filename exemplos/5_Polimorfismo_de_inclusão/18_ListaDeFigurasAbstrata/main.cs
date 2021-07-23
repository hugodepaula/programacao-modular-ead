using System;
using System.Drawing;

class MainClass
{
  public static Figura[] figuras = new Figura[10];
  public static int numFig = 0;

  public static void Main(string[] args)
  {
    figuras[numFig++] = new Quadrado(10, 20, 50, Color.Red, true);
    figuras[numFig++] = new Circulo(213, 78, 80, Color.Navy, true);
    figuras[numFig++] = new Quadrado(95, 4, 120, Color.Brown, true);

    for (int pos = 0; pos < numFig; pos++) 
    {
      figuras[pos].Desenha();
    }

  }
}

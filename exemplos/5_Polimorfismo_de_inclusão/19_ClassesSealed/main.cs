using System;

namespace ClassesSealed
{
  class Estensivel
  {
    public virtual void Primeiro()
    {
      Console.WriteLine("Estensível: primeiro método.");
    }
    public virtual void Segundo()
    {
      Console.WriteLine("Estensível: segundo método.");
    }
  }
  class MembroSelado : Estensivel
  {
    public sealed override void Primeiro()
    {
      Console.WriteLine("Membro Selado: primeiro método.");
    }
    public override void Segundo()
    {
      Console.WriteLine("Membro Selado: segundo método.");
    }
  }
  sealed class Selada : MembroSelado
  {
    // Tentativa de sobrepor um método selado
    // error CS0239: 'Selada.Primeiro()': cannot override inherited member 'MembroSelado.Primeiro()'
    protected override void Primeiro() 
    { 
      Console.WriteLine("Selada: primeiro método.");
    }

    public override void Segundo()
    {
      Console.WriteLine("Selada: segundo método.");
    }
  }

  // Tentativa de estender uma classe selada.
  // error CS0509: 'Sobreposicao': cannot derive from sealed type 'Selada'
  class Sobreposicao : Selada
  {
    protected override void Primeiro() 
    { 
      Console.WriteLine("Sobreposicao: primeiro método.");
    }

    public override void Segundo()
    {
      Console.WriteLine("Sobreposicao: segundo método.");
    }
  }


  class MainClass {
    public static void Main (string[] args) 
    {
      Console.WriteLine ("O código não compila.");
    }
  }
}


using System;

class MainClass 
{
  public const float REJEITA_MAIOR = -1;
  public const float JA_SUBSIDIADO = 250;
  public const float TEMPO_INTEGRAL = 500;
  public const float FATOR = 0.5F;

  public static bool idade = false,
      sub = false,
      naointegral = false,
      eMaior = false,
      eTempoParcial = false,
      jaSubsidiado = false;

//-------------------------------------

  public static int calcsub() {
    int subsidio;
    if (!idade) // não acima do limite
      if (!sub) //sem subsidio
        if (!naointegral) 
          subsidio = 500; // não tempo parcial
        else subsidio = 250;
      else subsidio = 250; // já subsidiado
    else subsidio = -1; // acima do limite
    return subsidio;
  }

//-------------------------------------

  float CalcSubsidio() 
  {
    float subsidio;
    if (eMaior) 
    {
      subsidio = REJEITA_MAIOR;
    } 
    else if (jaSubsidiado) 
    {
      subsidio = JA_SUBSIDIADO;
    } 
    else if (eTempoParcial) 
    {
      subsidio = TEMPO_INTEGRAL*FATOR;
    } 
    else 
    {
      subsidio = TEMPO_INTEGRAL;
    }
    return subsidio;
  }
  

  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
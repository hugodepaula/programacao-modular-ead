using System;
using System.Collections.Generic;


namespace _22_ExemploDeDicionario
{
  /*
    Este programa calcula a frequencia de ocorrencia de termos em um documento.
  */
  class Program
  {
    /*
      Utilizaremos o "Poema das sete faces" de Carlos Drummond de Andrade como entrada para contar a ocorrência de termos em um texto.
    */
    public static string poema =
    @"Quando nasci, um anjo torto
desses que vivem na sombra
disse: Vai, Carlos! ser gauche na vida.

As casas espiam os homens
que correm atrás de mulheres.
A tarde talvez fosse azul,
não houvesse tantos desejos.

O bonde passa cheio de pernas:
pernas brancas pretas amarelas.
Para que tanta perna, meu Deus, pergunta meu coração.
Porém meus olhos
não perguntam nada.

O homem atrás do bigode
é sério, simples e forte.
Quase não conversa.
Tem poucos, raros amigos
o homem atrás dos óculos e do -bigode,

Meu Deus, por que me abandonaste
se sabias que eu não era Deus
se sabias que eu era fraco.

Mundo mundo vasto mundo,
se eu me chamasse Raimundo
seria uma rima, não seria uma solução.
Mundo mundo vasto mundo,
mais vasto é meu coração.

Eu não devia te dizer
mas essa lua
mas esse conhaque
botam a gente comovido como o diabo.";

    static void Main(string[] args)
    {
      // Coloca tudo em minúsculo e separa o texto em palavras
      char[] delimiterChars = { ' ', ',', '.', ':', '!', '?', '-', '\t', '\n' };
      var termList = poema.ToLower().Split(delimiterChars, System.StringSplitOptions.TrimEntries & System.StringSplitOptions.RemoveEmptyEntries);


      // Para cada palavra do texto, irá contar quantas vezes a palavra apareceu.
      // Um dicionário irá armazenar a palavra na primeira vez que ela aparecer 
      // e depois irá incrementar o contador toda vez que ela aparecer novamente.

      SortedDictionary<string, Int32> termFrequency = new SortedDictionary<string, int>();
      foreach (var term in termList)
      {
        // Remove os espaços em branco e só adiciona se não for vazio.
        var termNoSpaces = term.Trim();
        if (termNoSpaces.Length >= 1)
        {
          if (termFrequency.ContainsKey(termNoSpaces))
          {
            termFrequency[termNoSpaces]++;
          }
          else
          {
            termFrequency.Add(termNoSpaces.Trim(), 1);
          }
        }
      }
      Console.WriteLine();
      foreach (KeyValuePair<string, Int32> term in termFrequency)
      {
        Console.WriteLine("{0}: {1}", term.Key, term.Value);
      }
    }
  }
}

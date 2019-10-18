using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Examples {
  class SkipTake {
    public void t1 () {
      List<string> nomes = new List<string> () {
        "Luiz",
        "Filipy",
        "Ana",
        "Juliana",
        "Maria",
        "João"
      };

      Console.WriteLine ("Retorna o elemento no indice 3 e 2");
      var limit = nomes.Skip (3).Take (2).ToList ();
      // var limit = nomes.Skip (3).ToList (); // ira retornar todos os elementos a partir do terceiro indice
      foreach (var n in limit) {
        Console.WriteLine (n);
      }
    }
  }
}
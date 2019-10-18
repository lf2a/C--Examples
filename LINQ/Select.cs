using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Examples {
  class Browser {
    public string empresa { get; set; }
    public string nome { get; set; }
  }

  class Select {
    public void t1 () {
      List<Browser> brs = new List<Browser> () {
        new Browser () { empresa = "Mozilla", nome = "Firefox" },
        new Browser () { empresa = "Google", nome = "Google Chrome" },
        new Browser () { empresa = "Microsoft", nome = "Edge" },
        new Browser () { empresa = "Apple", nome = "Safari" }
      };

      // retorna somente os nomes contido na lista de objetos
      Console.WriteLine ("Nomes de Browsers mais conhecidos");
      List<string> nomeBrowser = brs.Select (n => n.nome).ToList ();
      foreach (var b in nomeBrowser) {
        Console.WriteLine (b);
      }

      Console.WriteLine ("\nNomes de Browsers mais conhecidos (objeto)");
      List<Browser> browsers = nomeBrowser.Select (n => new Browser { nome = n }).ToList ();
      foreach (var b in browsers) {
        Console.WriteLine (b.nome);
      }
    }
  }
}
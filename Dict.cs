using System;
using System.Collections.Generic;

namespace C__Examples {
  class Dict {
    public void showDict () {
      Dictionary<string, int> user = new Dictionary<string, int> ();
      user.Add ("Luiz", 19);
      user.Add ("Filipy", 20);
      user.Add ("Ana", 23);

      Console.WriteLine ("user[\"Luiz\"]: " + user["Luiz"]);

      if (user.ContainsKey ("abc")) {
        Console.WriteLine (user["abc"]);
      } else {
        Console.WriteLine ("chave 'abc' não existe\n");
      }

      foreach (KeyValuePair<string, int> u in user) {
        Console.WriteLine ("Chave: " + u.Key);
        Console.WriteLine ("Valor: " + u.Value + "\n");
      }
    }
  }
}
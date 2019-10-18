using System;

namespace C__Examples {
  class Loop {
    public void loop (int[] idade, params string[] nome) {
      // while
      Console.WriteLine ("--- While ---");

      int i = 0;
      while (i < idade.Length) {
        Console.Write (idade[i] + " ");
        i++;
      }

      Console.WriteLine ("");

      i = 0;
      do {
        Console.Write (nome[i] + " ");
        i++;
      } while (i < idade.Length);

      Console.WriteLine ("\n--- Fim While ---\n");
      // fim while

      // for
      Console.WriteLine ("--- For ---");

      for (int a = 0; a < idade.Length; a++) {
        Console.Write (idade[a] + " ");
      }

      Console.WriteLine ("");

      for (int j = 0; j < nome.Length; j++) {
        Console.Write (nome[j] + " ");
      }

      Console.WriteLine ("\n--- Fim For ---\n");
      // fim for

      // foreach
      Console.WriteLine ("--- Foreach ---");

      foreach (int age in idade) {
        Console.Write (age + " ");
      }

      Console.WriteLine ("");

      foreach (string n in nome) {
        Console.Write (n + " ");
      }

      Console.WriteLine ("\n--- Fim Foreach ---\n");
      // fim foreach
    }
  }
}
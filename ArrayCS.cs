using System;

namespace C__Examples {
  class ArrayCS {
    public void array () {
      string[] nomes = new string[5];
      nomes[0] = "Luiz";

      foreach (string n in nomes) {
        Console.WriteLine (n != null ? n : "null");
      }

      int[] idade = new int[5] { 23, 5, 3, 65, 78 };
      // ou
      // int[] idade = { 23, 5, 3, 65, 78 };
      foreach (int i in idade) {
        Console.WriteLine (i);
      }
    }
  }
}
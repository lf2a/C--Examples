using System;

namespace C__Examples {
  class Funcao {
    public float divisao (float v1, float v2) {
      return v1 / v2;
    }

    public void noRef (int v1) {
      v1 += 1;
    }

    public void comRef (ref int v1) {
      v1 += v1;
    }

    public void paramsTeste (float PI, params int[] number) {
      Console.WriteLine ("PI: " + PI + "\nNumber[] tamanho: " + number.Length);
    }
  }
}
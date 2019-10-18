using System;

namespace C__Examples {
  public enum Mes {
    SEGUNDA = 2,
    TERCA,
    QUARTA,
    QUINTA,
    SEXTA,
    SABADO,
    DOMINGO = 1
  }

  class Enum {
    public void t1 () {
      Mes mes = Mes.SEGUNDA;
      Console.WriteLine (mes);
      Console.WriteLine ((int) mes);
    }
  }
}
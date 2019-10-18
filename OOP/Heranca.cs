using System;

public class Veiculo {
  public void ligar () {
    Console.WriteLine ("Veiculo ligado!");
  }

  public virtual void buzina () {
    Console.WriteLine ("Buzina do Veiculo ativa!");
  }
}

namespace C__Examples {

  class Barco : Veiculo {
    public override void buzina () {
      Console.WriteLine ("Buzina do Barco ativa!");

      Console.WriteLine ("Chamando buzina() da classe pai");
      base.buzina ();
    }
  }
}
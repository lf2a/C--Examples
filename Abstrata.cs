using System;

// classes abstratas não podem ser instanciadas só herdadas
abstract class Animal {
  public virtual void print () {
    Console.WriteLine ("Print Animal");
  }
}

namespace C__Examples {
  class Cachorro : Animal {
    public override void print () {
      Console.WriteLine ("Print Cachorro");
      base.print ();
    }
  }
}
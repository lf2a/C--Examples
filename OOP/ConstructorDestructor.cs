using System;

namespace C__Examples {
  class Moto {
    public Moto () {
      Console.WriteLine ("Constructor Moto()");
    }

    // `:this()` chama o construtor sem parametros
    public Moto (string modelo) : this () {
      Console.WriteLine ("Constructor Moto(" + modelo + ")");
    }

    public Moto (string marca, string modelo, int cilindrada) : this (modelo) {
      Console.WriteLine ("Constructor Moto(" + marca + ", " + cilindrada + ")");
    }

    ~Moto () {
      Console.WriteLine ("Destructor...");
    }
  }
}
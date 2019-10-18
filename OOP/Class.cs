using System;

// a classe `Carro` só é visivel nesta classe `Class`
class Carro {
  private string marca { get; }
  private string modelo { get; }
  private string dono { get; set; }

  public Carro (string marca, string modelo) {
    this.marca = marca;
    this.modelo = modelo;
  }

  public string Getmarca {
    get { return this.marca; }
  }

  public string getModelo {
    get { return this.modelo; }
  }

  public string Dono {
    get { return this.dono; }
    set { this.dono = value; }
  }
}

namespace C__Examples {
  class Class {
    public void testeCarro () {
      var carro = new Carro ("Ferrari", "California");
      carro.Dono = "Luiz Filipy";
      Console.WriteLine ("Marca: " + carro.Getmarca + "\nModelo: " + carro.getModelo + "\nDono: " + carro.Dono);
    }
  }
}
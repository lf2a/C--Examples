using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Examples {

  class Celular {
    public string marca { get; set; }
    public string modelo { get; set; }
  }

  class Where {
    public void t1 () {
      List<int> idades = new List<int> () {
        12,
        6,
        17,
        45,
        34,
        86,
        98
      };

      var menorDeIdade = idades.Where (i => i < 18);
      Console.WriteLine ("Menores de idade");
      foreach (var idade in menorDeIdade) {
        Console.WriteLine (idade);
      }

      Console.WriteLine ("Maiores de idade (com 45 e 98)");
      var maiores = idades.Where (i => i >= 18 && i != 45);
      foreach (var idade in maiores) {
        Console.WriteLine (idade);
      }
    }

    public void t2 () {
      List<int> id = new List<int> () {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9
      };

      List<int> idBloqueados = new List<int> () {
        1,
        5,
        9
      };

      Console.WriteLine ("IDs Permitidos");
      var idsPermitidos = id.Where (id => !idBloqueados.Contains (id));
      foreach (var _id in idsPermitidos) {
        Console.WriteLine (_id);
      }
    }

    public void t3 () {
      List<Celular> celulares = new List<Celular> () {
        new Celular () { marca = "Samsung", modelo = "S10" },
        new Celular () { marca = "Apple", modelo = "Iphone X" },
        new Celular () { marca = "Samsung", modelo = "Note 9" }
      };

      Console.WriteLine ("Celulares Samsung");
      var celularesSamsung = celulares.Where (cel => cel.marca == "Samsung");
      // var celularesSamsung = celulares.Where (cel => cel.marca == "Apple");
      foreach (var celular in celularesSamsung) {
        Console.WriteLine (celular.modelo);
      }
    }
  }
}
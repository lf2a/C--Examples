using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Examples {
  class Notebook {
    public string marca { get; set; }
    public string modelo { get; set; }
    public double preco { get; set; }
  }

  class Sort {
    public void t1 () {
      List<int> idades = new List<int> () {
        5,
        2,
        23,
        85,
        3,
        18,
        90
      };

      Console.WriteLine ("Antes");
      foreach (var idade in idades) {
        Console.WriteLine (idade);
      }

      Console.WriteLine ("\nSort idades");
      List<int> idadesSort = idades.OrderBy (i => i).ToList ();
      foreach (var idade in idadesSort) {
        Console.WriteLine (idade);
      }
    }

    public void t2 () {
      List<string> cidades = new List<string> () {
        "São Paulo",
        "Belém",
        "Paragominas",
        "Ananindeua",
        "Curitiba"
      };

      Console.WriteLine ("Cidades lista original");
      foreach (var cid in cidades) {
        Console.WriteLine (cid);
      }

      Console.WriteLine ("\nCidades ordem decrescente");
      List<string> ordemDec = cidades.OrderByDescending (c => c).ToList ();
      foreach (var cid in ordemDec) {
        Console.WriteLine (cid);
      }

      Console.WriteLine ("\nCidades em ordem crecente");
      List<string> ordemCre = cidades.OrderBy (c => c).ToList ();
      foreach (var cid in ordemCre) {
        Console.WriteLine (cid);
      }
    }

    public void t3 () {
      List<Notebook> notebooks = new List<Notebook> () {
        new Notebook () { marca = "Dell", modelo = "Inspiron 7000", preco = 6745.90 },
        new Notebook () { marca = "Apple", modelo = "MacBook pro", preco = 10000.00 },
        new Notebook () { marca = "Microsoft", modelo = "Surface", preco = 7000.00 }
      };

      Console.WriteLine ("Lista original");
      foreach (var n in notebooks) {
        Console.WriteLine ($"{n.marca} {n.modelo} R$:{n.preco}");
      }

      Console.WriteLine ("\nOrdenando por nome");
      List<Notebook> ordermCre = notebooks.OrderBy (n => n.marca).ToList ();
      foreach (var n in ordermCre) {
        Console.WriteLine ($"{n.marca} {n.modelo} R$:{n.preco}");
      }

      Console.WriteLine ("\nOrdenando dec por nome");
      List<Notebook> ordermDec = notebooks.OrderByDescending (n => n.marca).ToList ();
      foreach (var n in ordermDec) {
        Console.WriteLine ($"{n.marca} {n.modelo} R$:{n.preco}");
      }
    }

    public void t4 () {
      List<Notebook> notebooks = new List<Notebook> () {
        new Notebook () { marca = "Dell", modelo = "XPS 15", preco = 6000.00 },
        new Notebook () { marca = "Dell", modelo = "Inspiron 7000", preco = 6000.00 },
        new Notebook () { marca = "Apple", modelo = "MacBook pro", preco = 10000.00 },
        new Notebook () { marca = "Microsoft", modelo = "Surface", preco = 7000.00 }
      };

      Console.WriteLine ("Lista original");
      foreach (var n in notebooks) {
        Console.WriteLine ($"{n.marca} {n.modelo} {n.preco}");
      }

      Console.WriteLine ("\nOrdenando cre notebooks");
      List<Notebook> notebooksCre = notebooks.OrderBy (n => n.preco).ThenBy (n => n.modelo).ToList ();
      foreach (var n in notebooksCre) {
        Console.WriteLine ($"{n.marca} {n.modelo} {n.preco}");
      }

      Console.WriteLine ("\nOrdenando dec notebooks");
      List<Notebook> notebooksDec = notebooks.OrderBy (n => n.preco).ThenByDescending (n => n.modelo).ToList ();
      foreach (var n in notebooksDec) {
        Console.WriteLine ($"{n.marca} {n.modelo} {n.preco}");
      }
    }
  }
}
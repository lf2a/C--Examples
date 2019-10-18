using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Examples {
  class Estado {
    public string nome { get; set; }
    public string regiao { get; set; }
  }
  class GroupBy {
    public void t1 () {
      List<Estado> estados = new List<Estado> () {
        new Estado () { nome = "Pará", regiao = "Norte" },
        new Estado () { nome = "Amazonas", regiao = "Norte" },
        new Estado () { nome = "Maranhão", regiao = "Nordeste" },
        new Estado () { nome = "Ceará", regiao = "Nordeste" },
        new Estado () { nome = "Mato-Grosso", regiao = "Centro-Oeste" },
        new Estado () { nome = "Goiás", regiao = "Centro-Oeste" },
      };

      Console.WriteLine ("Estados da região norte, nordeste e centro-oeste");
      var regiaoNorte = estados.GroupBy (n => n.regiao);
      foreach (var group in regiaoNorte) {
        Console.WriteLine ($"\nRegiao: {group.Key}");
        foreach (var e in group) {
          Console.WriteLine ($"\testado: {e.nome}");
        }
      }
    }
  }
}
using System;

namespace C__Examples {
  struct ID {
    private string _nome;
    public string nome {
      get { return this._nome; }
      set { this._nome = value; }
    }
  }

  class Struct {
    ID id;

    public void t1 () {
      id = new ID ();
      id.nome = "Luiz Filipy";
      Console.WriteLine (id.nome);
    }
  }
}
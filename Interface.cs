using System;

namespace C__Examples {
  interface IRadio {
    void ligar ();
    void desligar ();

    string marca { get; set; }
    string modelo { get; set; }
  }

  // TODOS os métodos e atributos DEVEM OBRIGATORIAMENTE ser importados
  class Radio : IRadio {
    public string marca { get; set; }
    public string modelo { get; set; }

    public void ligar () { /* qualquer implementacao */ }

    public void desligar () { /* qualquer implementacao */ }
  }
}
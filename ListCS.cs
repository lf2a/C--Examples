using System;
using System.Collections.Generic;

namespace C__Examples {
  class User {
    private string nome;
    public string GetNome {
      get { return this.nome; }
    }

    private int idade;
    public int GetIdade {
      get { return this.idade; }
    }

    public User (string nome, int idade) {
      this.nome = nome;
      this.idade = idade;
    }
  }

  class Iter {
    public void showUser () {
      List<User> users = new List<User> () {
        new User ("Luiz", 19),
        new User ("Filipy", 25),
        new User ("Ana", 28),
        new User ("Juliana", 32)
      };

      users.Add (new User ("Paula", 31));
      users.Insert (2, new User ("Mayane", 21));
      users.AddRange (new User[] { new User ("Jessica", 18), new User ("Pedro", 34) });

      foreach (User user in users) {
        Console.WriteLine ("HashCode: " + user.GetHashCode ());
        Console.WriteLine ("Nome: " + user.GetNome);
        Console.WriteLine ("Idade: " + user.GetIdade + "\n");
      }
    }
  }
}
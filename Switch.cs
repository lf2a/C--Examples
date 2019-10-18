using System;

namespace C__Examples {
  class Switch {
    public void testSwitch (string marca) {
      switch (marca) {
        case "samsung":
          Console.WriteLine ("Samsung");
          break;
        case "nokia":
          Console.WriteLine ("Tijolao");
          break;
        default:
          Console.WriteLine ("");
          break;
      }
    }
  }
}
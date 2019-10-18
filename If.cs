using System;

namespace C__Examples {
  class If {
    public bool testAge (int idade) {
      if ((idade == 0) || (idade < 0)) {
        return false;
      } else if ((idade > 0) && (idade < 13)) {
        return false;
      } else if ((idade > 13) && (idade < 18)) {
        return false;
      } else if (idade > 18) {
        return true;
      } else {
        return false;
      }
    }
  }
}
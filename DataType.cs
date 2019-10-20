using System;

namespace C__Examples {
  class DataType {
    public void t1 () {
      DateTime dt = new DateTime (2019, 10, 18, 13, 24, 00);

      Console.WriteLine (dt.ToString ());
      Console.WriteLine (dt.ToString ("yyyymmddHHmmss"));
    }

    public void t2 () {
      dynamic pessoa = "Luiz Filipy";
      pessoa = 19;
      Console.WriteLine (pessoa);
    }
  }
}
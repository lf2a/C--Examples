using System;
using System.IO;

namespace C__Examples {
  class ReadAndWrite {
    string arquivo = "rw.txt";
    string diretorio = "test";
    public void t1 () {
      string conteudo;
      if (File.Exists (arquivo)) {
        conteudo = File.ReadAllText (arquivo);
        Console.WriteLine (conteudo);
      }
      Console.Write ("Digite o conteudo para ser inserido no arquivo: ");
      conteudo = Console.ReadLine ();
      File.WriteAllText (arquivo, conteudo);
    }

    public void t2 () {
      string conteudo = "conteudo adicionado";
      File.AppendAllText (arquivo, Environment.NewLine + conteudo);
    }

    public void t3 () {
      if (File.Exists (arquivo)) {
        File.Delete (arquivo);
        if (!File.Exists (arquivo)) {
          Console.WriteLine ("Arquivo apagado com sucesso!");
        }
      } else {
        Console.WriteLine ("Arquivo não existe!");
      }
    }

    public void t4 () {
      if (Directory.Exists (diretorio)) {
        Directory.Delete (diretorio);
        if (!Directory.Exists (diretorio)) {
          Console.WriteLine ("Apagado com sucesso!");
        }
      } else {
        Console.WriteLine ("Diretorio não existe!");
      }
    }

    public void t5 () {
      string novoNome = "rw-renomeado.txt";
      if (File.Exists (arquivo)) {
        File.Move (arquivo, novoNome);
        if (File.Exists (novoNome)) {
          Console.WriteLine ("Renomeado com sucesso!");
        }
      }
    }

    public void t6 () {
      string novoNome = "test-renomeado";
      if (Directory.Exists (diretorio)) {
        Directory.Move (diretorio, novoNome);
        if (Directory.Exists (novoNome)) {
          Console.WriteLine ("Renomeado com sucesso!");
        }
      }
    }

    public void t7 () {
      if (!Directory.Exists (diretorio)) {
        Directory.CreateDirectory (diretorio);
        if (Directory.Exists (diretorio)) {
          Console.WriteLine ("Diretorio criado com sucesso!");
        }
      }
    }

    public void t8 () {
      FileInfo file = new FileInfo (System.Reflection.Assembly.GetExecutingAssembly ().Location);
      if (file != null) {
        Console.WriteLine ($"Nome: {file.Name}");
        Console.WriteLine ($"Tamanho: {file.Length} bytes");
        Console.WriteLine ($"Ultima vez modificado: {file.LastWriteTime}");
        Console.WriteLine ($"Path: {file.FullName}");
      }
    }

    public void t9 () {
      DirectoryInfo di = new DirectoryInfo (Path.GetDirectoryName (System.Reflection.Assembly.GetExecutingAssembly ().Location));
      if (di != null) {
        FileInfo[] files = di.GetFiles ();
        if (files.Length > 0) {
          Console.WriteLine ("Files: ");
          foreach (FileInfo fi in files) {
            Console.WriteLine ($"{fi.Name} ({fi.Length} bytes)");
          }
        }
      }
    }
  }
}
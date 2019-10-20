using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Note_CRUD.Models {
  public class NoteContext {
    public string ConnectionString { get; set; }

    public NoteContext (string connectionString) {
      this.ConnectionString = connectionString;
    }

    private MySqlConnection GetConnection () {
      return new MySqlConnection (ConnectionString);
    }

    public List<Note> GetAll () {
      List<Note> notes = new List<Note> ();

      using (MySqlConnection conn = GetConnection ()) {
        conn.Open ();
        MySqlCommand cmd = new MySqlCommand ("select * from Note", conn);

        using (var reader = cmd.ExecuteReader ()) {
          while (reader.Read ()) {
            notes.Add (new Note () {
              id = reader["id"].ToString (),
                titulo = reader["titulo"].ToString (),
                autor = reader["autor"].ToString (),
                nota = reader["nota"].ToString (),
            });
          }
        }
      }
      return notes;
    }

    public Note Get (int id) {
      Note note = new Note ();
      using (MySqlConnection conn = GetConnection ()) {
        conn.Open ();
        MySqlCommand cmd = new MySqlCommand ($"select * from Note where id={id}", conn);

        using (var reader = cmd.ExecuteReader ()) {
          while (reader.Read ()) {
            note.id = reader["id"].ToString ();
            note.titulo = reader["titulo"].ToString ();
            note.autor = reader["autor"].ToString ();
            note.nota = reader["nota"].ToString ();
          }
        }
      }
      return note;
    }

    public Note Edit (int id, Note n) {
      Note note = new Note ();
      note = Get (id);

      if (note.id != null) {
        using (MySqlConnection conn = GetConnection ()) {
          conn.Open ();
          MySqlTransaction mt = conn.BeginTransaction ();

          MySqlCommand cmd = new MySqlCommand ();
          cmd.Connection = conn;
          cmd.Transaction = mt;

          if (n.titulo != null || n.autor != null || n.nota != null) {
            cmd.CommandText = $"UPDATE Note SET titulo='{n.titulo}', autor='{n.autor}', nota='{n.nota}' WHERE id={id}";
            cmd.ExecuteNonQuery ();

            mt.Commit ();
          }

          return Get (id);
        }
      } else {
        return new Note () {
          id = null,
            titulo = null,
            autor = null,
            nota = null,
        };
      }
    }

    public void Del (int id) {
      Note note = new Note ();
      note = Get (id);

      if (note.id != null) {
        using (MySqlConnection conn = GetConnection ()) {
          conn.Open ();

          MySqlCommand cmd = new MySqlCommand ();
          cmd.Connection = conn;
          cmd.CommandText = $"delete from Note where id={id}";
          cmd.ExecuteNonQuery ();
        }
      }
    }

    public bool Add (Note n) {
      using (MySqlConnection conn = GetConnection ()) {
        conn.Open ();

        MySqlCommand cmd = new MySqlCommand ();

        if (n.titulo != null || n.autor != null || n.nota != null) {
          cmd.Connection = conn;
          cmd.CommandText = $"INSERT INTO Note(titulo, autor, nota) VALUES('{n.titulo}', '{n.autor}', '{n.nota}')";
          cmd.Prepare ();

          cmd.ExecuteNonQuery ();
          return true;
        }
      }
      return false;
    }
  }
}
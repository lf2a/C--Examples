namespace Note_CRUD.Models {
  public class Note {
    /*
    create table Note (id int not null primary key auto_increment, 
        titulo varchar(50), 
        autor varchar(30), 
        nota varchar(200));
     */
    public string id { get; set; }
    public string titulo { get; set; }
    public string autor { get; set; }
    public string nota { get; set; }
  }
}
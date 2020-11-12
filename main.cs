using System;
using System.Collections.Generic;

class MainClass {
  public static void Main () { 
    List <ideia>   Lista_ideia    = new List<ideia>();

       
    votacao vt = new votacao (0, "nenhum");
    string cadastrar = "S";
    while (cadastrar == "S"){
      
      usuario anonimo = new usuario("anonimo", 0,"Confirma e-mail", 0);
      ideia   id      = new ideia  ("ideia", 0,"não especificada",  0);
      // // // descricao, votostotais, area, ranking

      Console.WriteLine("Deseja cadastrar um novo usuario ? S/N");
      cadastrar = Console.ReadLine();
      
      
      if (cadastrar == "S"){

        Console.WriteLine("diga o nome>>");
        string nome = Console.ReadLine();
        
        anonimo.Setnome(nome);
        Console.WriteLine("diga o email>>");

        string email = Console.ReadLine();
        anonimo.Setemail(email);
        Console.WriteLine ("diga o telefone>>");

        int telefone = int.Parse(Console.ReadLine());
        anonimo.Settelefone(telefone);
        anonimo.Setfundos(0);

        Console.WriteLine ("diga sua ideia");
         string descricao= Console.ReadLine();
         id.Setdescricao(descricao);

        Console.WriteLine("qual a aréa da sua ideia?");
        string area = Console.ReadLine();
        id.Setarea(area);

        Lista_ideia.Add(id);
        
        
      }

    } 

    List <votacao> Lista_votacaos = new List<votacao>();
    for(int i = 0; i<Lista_ideia.Count; i++){
      Console.WriteLine( Lista_ideia[i].Getdescricao() );


    }
  }
}
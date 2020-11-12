class ideia{
  public string descricao; 
  public int votostotais;
  public string area;
  private int ranking;

  public string Getdescricao(){
    return descricao;
  }
  public ideia(string d,int vt, string a, int rnk){
   descricao = d;
   votostotais = vt;
   area = a;
   ranking = rnk;
  }
  

}
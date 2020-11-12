class ideia{
  public string descricao; 
  public int votostotais;
  public string area;
  private int ranking;

  public string Getdescricao() {
    return descricao;
  }
  public int Getvotostotais() {
    return votostotais;
  }
  public string Getarea() {
    return area;
  }
  public int Getranking() {
    return ranking;
  }

  public void Setdescricao(string dc){
    descricao = dc;
  }
  public void Setvotostotais(int vt){
    votostotais = vt;
  }
  public void Setarea(string a){
    area = a;
  }
  public void Setranking(int r){
    ranking = r;
  }

  public ideia(string d,int vt, string a, int rnk){
   descricao = d;
   votostotais = vt;
   area = a;
   ranking = rnk;
  }
  

}
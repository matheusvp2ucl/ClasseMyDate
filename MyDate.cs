using System;
using System.Globalization;
using System.Threading;


class MyDate{

  // Atributos da Classe
  private DateTime varDate;
  private int dia;
  private int mes;
  private int ano;

  // Geters - Seters da Classe
  public DateTime Date{
    get{ return varDate; }
    set{ varDate = value; }
  }

  public int Day{
    get{ return dia; }
    set{ dia = value; }
  }

  public int Month{
    get{ return mes; }
    set{ mes = value; }
  }

  public int Year{
    get{ return ano; }
    set{ ano = value; }
  }

  // Funções privadas somente de uso interno da Classe
  private void SetAttrs(){
    this.dia = this.varDate.Day;
    this.mes = this.varDate.Month;
    this.ano = this.varDate.Year;
  }

  // Funções publicas para uso da instancia da Classe

  // Construtor vazio, retorna dia atual !
  public MyDate(){
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);
    this.varDate = DateTime.Now;
    this.SetAttrs();
  }

  // Construtor  com 3 parametros formando a data, se somente valida !
  public MyDate( int _dia, int _mes, int _ano ){
    try{
      // Tenta montar uma data valida, caso contrario lança uma exceção !
      new DateTime( _ano, _mes, _dia );
      // Caso não de erro ele seta padrao BR
      Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);
      // Inicia os Atributos
      this.dia = _dia;
      this.mes = _mes;
      this.ano = _ano;
      this.varDate = new DateTime( _ano, _mes, _dia );

    }catch(Exception ex){
      throw new Exception("Data Fornecida esta Invalida !", ex);
    }

  }

  // Metodo para retorna a data da classe formatada dia/mes/ano !
  public string toString(){
    string newDay = this.dia < 10 ? $"0{this.dia}" : $"{this.dia}";
    string newMonth = this.mes < 10 ? $"0{this.mes}" : $"{this.mes}";
    return $"{newDay}/{newMonth}/{this.ano}";
  }

  // Metodo para adicionar mais 1 dia a data da classe !
  public void nextDay(){

  }

}
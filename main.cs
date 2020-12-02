using System;
using System.Globalization;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {

    // Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);

    int ano = 1998 ;
    int mes = 05 ;
    int dia = 05 ;

    MyDate novaData = new MyDate( );

    Console.WriteLine( novaData.toString() );

  }
}
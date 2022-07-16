using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int[] OrderList = new int[] {0,6,3,2};
    int[] Ordenador = OrderList.OrderBy(x => x).ToArray();
    //int[] Ordenador = OrderList.OrderBy(x => x).ToArray();
    foreach(int element in Ordenador)
    {

      //Empilhar o resultado em ordem crescente;
      var operador = Math.Pow(element, 4);
      Console.WriteLine(operador);
    }

  }
}
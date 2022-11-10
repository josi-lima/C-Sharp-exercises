// ------ Function with factorial numbers ===========

using System;

class Program {

  public static void Main(string[] args) {
    int x = factorial(5);
    Console.WriteLine(x);
  }

  public static int factorial (int number) {
    int factor = 1;
    for (int index = number; index > 0; index -= 1) {
      factor *= index;
    }
    return factor;
  }
}
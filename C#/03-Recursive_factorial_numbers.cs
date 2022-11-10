// ------ Recursive function with factorial numbers ===========

using System;

class Program {

  public static void Main(string[] args) {
    int x = factorial(5);
    Console.WriteLine(x);
  }

 public static int factorial(int number) {
  if (number == 1) {
    return 1;
  }
  return number * factorial(number - 1);
 }
}

using System;

class Program {
  public static void Main (string[] args) {
    int n, k;
    Console.WriteLine ("Введите число N: ");
    n = Convert.ToInt32(Console.ReadLine());
    k = (n + 2) + (n % 2);
    
    while (k > n) {
      k++;
      if (k % 9 == 5) {
        Console.WriteLine(k);
        break;
      }
    }

    Console.ReadKey();
}
}
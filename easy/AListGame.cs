using System;

class Program
{
  static void Main(string[] args)
  {
    int current = int.Parse(Console.ReadLine());
    int points = 1;

    int divider = 2;
    while(current > 1 && divider <= Math.Sqrt(current))
    {
      if (current % divider == 0) {
        points++;
        current /= divider;
      } else {
        divider++;
      }
    }
    Console.WriteLine(points);
  }
}
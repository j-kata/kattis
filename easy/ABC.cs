using System;
using System.Linq;
class Program
{
  public static void Main(string[] args)
  {
    string numbers = Console.ReadLine().Trim();
    string order = Console.ReadLine().Trim();

    int[] abc = numbers.Split(" ").Select(int.Parse).ToArray();
    Array.Sort(abc);

    var result = order.Select(ch => abc[ch - 'A']);
    Console.WriteLine(String.Join(" ", result));
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

class Program
{
  static readonly List<(Func<int, int, int>, char)> operations = new() {
    ((a, b) => a * b, '*'),
    ((a, b) => a + b, '+'),
    ((a, b) => a - b, '-'),
    ((a, b) => a / b, '/')
  };

  public static void Main(string[] args)
  {
    string[] numbers = Console.ReadLine().Trim().Split(" ");
    int a = int.Parse(numbers[0]);
    int b = int.Parse(numbers[1]);
    int c = int.Parse(numbers[2]);
    int d = int.Parse(numbers[3]);

    List<string> equations = ValidEquations(a, b, c, d);
    if (equations.Count != 0) {
      equations.ForEach(eq => Console.WriteLine(eq));
    } else {
      Console.WriteLine("problems ahead");
    }
  }

  static List<string> ValidEquations(int a, int b, int c, int d)
  {
    List<string> validEquations = new();
    foreach (var (op1, sym1) in operations)
    {
      foreach (var (op2, sym2) in operations)
      {
        try {
          if (op1(a, b) == op2(c, d))
            validEquations.Add($"{a} {sym1} {b} = {c} {sym2} {d}");
        } catch(DivideByZeroException) {}
      }
    }
    return validEquations;
  }
}

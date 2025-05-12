using System;

class Program
{
  static void Main(string[] args)
  {
    string input = Console.ReadLine();
    string[] values = input.Split(' ');
    int x = int.Parse(values[0]);
    int y = int.Parse(values[1]);
    int n = int.Parse(values[2]);

    string[] replaced = FizzBuzz(n, x, y);
    foreach(string num in replaced)
      Console.WriteLine(num);
  }

  static string[] FizzBuzz(int n, int x, int y)
  {
    var result = new string[n];
    for(int i = 1; i <= n; i++) {
      string replacement = ReplaceDivisible(i, x, "Fizz") + ReplaceDivisible(i, y, "Buzz");
      result[i - 1] = replacement.Length > 0 ? replacement : i.ToString();
    }
    return result;
  }

  static string ReplaceDivisible(int n, int x, string word)
  {
    return n % x == 0 ? word : "";
  }
}
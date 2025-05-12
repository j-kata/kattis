using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
  public static void Main(string[] args)
  {
    string[] line = Console.ReadLine().Split(" ");
    int numLen = int.Parse(line[0]);
    int operation = int.Parse(line[1]);

    line = Console.ReadLine().Trim().Split(" ");
    int[] numbers = line.Select(int.Parse).ToArray();

    switch (operation)
    {
      case 1:
        Console.WriteLine(HasSum(numbers, 7777) ? "Yes" : "No");
        break;
      case 2:
        Console.WriteLine(IsUnique(numbers) ? "Unique" : "Contains duplicate");
        break;
      case 3:
        Console.WriteLine(PrevailingNumber(numbers));
        break;
      case 4:
        Console.WriteLine(string.Join(" ", Medians(numbers)));
        break;
      case 5:
        Console.WriteLine(string.Join(" ", InRange(numbers, 100, 999)));
        break;
    }
  }

  static bool HasSum(int[] numbers, int value)
  {
    HashSet<int> seen = new();
    foreach (int num in numbers)
    {
      if (seen.Contains(value - num)) return true;
      seen.Add(num);
    }
    return false;
  }

  static bool IsUnique(int[] numbers)
  {
    HashSet<int> hash = new(numbers);
    return hash.Count == numbers.Length;
  }

  static int PrevailingNumber(int[] numbers)
  {
    Dictionary <int,int> dict = new();
    foreach (int num in numbers)
    {
      dict[num] = dict.ContainsKey(num) ? dict[num] + 1 : 1;
    }
    var prevailing = dict.Where(kv => kv.Value > numbers.Length/2).FirstOrDefault();
    return prevailing.Value == 0 ? -1 : prevailing.Key;
  }

  static int[] Medians(int[] numbers)
  {
    Array.Sort(numbers);
    int m = numbers.Length / 2;

    return numbers.Length % 2 == 0 ? new int[] { numbers[m - 1], numbers[m]} : new int[] { numbers[m] };
  }

  static int[] InRange(int[] numbers, int start, int stop)
  {
    Array.Sort(numbers);
    return numbers.Where(x => start <= x && x <= stop).ToArray();
  }
}
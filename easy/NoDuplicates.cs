using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
  public static void Main(string[] args)
  {
    string[] words = Console.ReadLine().Trim().Split(" ");

    Console.WriteLine(HasDuplicates(words) ? "no" : "yes");
  }

  static bool HasDuplicates(string[] words)
  {
    HashSet <string> set = new();
    foreach (var word in words)
    {
      if (!set.Add(word)) return true;
    }
    return false;
  }
}
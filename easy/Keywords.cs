using System;
using System.Collections.Generic;
class Program
{
  public static void Main(string[] args)
  {
    int wordCount = int.Parse(Console.ReadLine().Trim());
    HashSet<string> words = new();
    for (int i = 0; i < wordCount; i++)
    {
      string word = Console.ReadLine().Trim().ToLower().Replace('-', ' ');
      words.Add(word);
    }
    Console.WriteLine(words.Count);
  }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static readonly List<(int, string)> scoreList = new();
  static readonly List<List<string>> finishes = new();

  public static void Main(string[] args)
  {
    int rest = int.Parse(Console.ReadLine().Trim());

    PopulateScoreList();
    CalculateFinishes(3, rest, new List<string>());

    Console.WriteLine(finishes.Count);
    foreach(var finish in finishes)
    {
      Console.WriteLine(finish.Count);
      foreach (string singleThrow in finish)
        Console.WriteLine(singleThrow);
    }
  }

  static void PopulateScoreList()
  {
    for(int i = 1; i <= 20; i++)
    {
      scoreList.Add((i, $"Single {i}"));
      scoreList.Add((i * 2, $"Double {i}"));
      scoreList.Add((i * 3, $"Triple {i}"));
    }
    scoreList.Add((25, "Outer bullseye"));
    scoreList.Add((50, "Bullseye"));
  }

  static void CalculateFinishes(int throwsRemain, int restScore, List<string> sequence)
  {
    if (throwsRemain <= 0) return;

    foreach (var (val, path) in scoreList)
    {
      if (val > restScore) continue;
      List<string> newSequence = sequence.ToList();
      newSequence.Add(path);
      if (val == restScore)
      {
        finishes.Add(newSequence);
        continue;
      } else {
        CalculateFinishes(throwsRemain - 1, restScore - val, newSequence);
      }
    }
    return;
  }
}
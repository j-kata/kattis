using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static readonly Dictionary<string, int> variables = new();
  private const string UNKNOWN = "unknown";
  static void Main(string[] args)
  {
    while (true)
    {
      string line = Console.ReadLine();
      if (string.IsNullOrWhiteSpace(line)) break;

      string[] tokens = line.Trim().ToLower().Split();
      switch (tokens[0])
      {
        case "def":
          Define(tokens[1..]);
          break;
        case "calc":
          string result = Calc(tokens[1..]);
          if (result != UNKNOWN)
            result = FindVarByValue(int.Parse(result));
          Console.WriteLine($"{string.Join(" ", tokens[1..])} {result}");
          break;
        case "clear":
          Clear();
          break;
      }
    }
  }
  static string FindVarByValue(int value)
  {
    var key = variables.FirstOrDefault(kv => kv.Value == value).Key;
    return key ?? UNKNOWN;
  }

  static void Define(string[] tokens)
  {
    string name = tokens[0];
    int value = int.Parse(tokens[1]);
    variables[name] = value;
  }

  static string Calc(string[] tokens)
  {
    if (tokens.Last() != "=") return UNKNOWN;

    int result = 0;
    bool plusPending = true;

    for (int i = 0; i < tokens.Length - 1; i++)
    {
      string token = tokens[i];
      bool isVar = variables.TryGetValue(token, out int variable);
      if (isVar) {
        result += plusPending ? variable : -1 * variable;
      } else if (token == "+") {
        plusPending = true;
      } else if (token == "-") {
        plusPending = false;
      }else {
        return UNKNOWN;
      }
    }
    return result.ToString();
  }

  static void Clear()
  {
    variables.Clear();
  }
}
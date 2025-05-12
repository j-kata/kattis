using System;

class Program
  {
    private const int LETTERS = 26;
    static void Main(string[] args)
    {
      int linesNumber = int.Parse(Console.ReadLine());
      string line;
      for (int i = 0; i < linesNumber; i++)
      {
        line = Console.ReadLine();
        Console.WriteLine(PangramStatus(line));
      }
    }

    static int[] LetterFrequencies(string str) {
      var letters = new int[LETTERS];

      for(int i = 0; i < str.Length; i++)
      {
        char letter = Char.ToLower(str[i]);
        int index = (int)letter - 'a';
        if (index < 0 || index >= LETTERS) continue;

        letters[index]++;
      }
      return letters;
    }

    static string PangramStatus(string str)
    {
      var frequency = LetterFrequencies(str);
      string missing = "";

      for (int i = 0; i < frequency.Length; i++)
        if (frequency[i] == 0) missing += (char)(i + 'a');

      return missing.Length > 0 ? $"missing {missing}" : "pangram";
    }
  }
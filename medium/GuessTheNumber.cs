using System;
class Program
{
  const int MAX = 1000;
  public static void Main(string[] args)
  {
    int start = 0;
    int end = MAX;
    int currentGuess;

    while (true) {
      currentGuess = start + (end - start + 1) / 2;
      Console.WriteLine(currentGuess);

      string feedback = Console.ReadLine();
      switch (feedback) {
        case "lower":
          end = currentGuess - 1;
          break;
        case "higher":
          start = currentGuess + 1;
          break;
        case "correct":
          return;
      }
      Console.Clear();
    }
  }
}
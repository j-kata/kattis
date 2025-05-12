using System;
class Program
{
  const int MAX = 99;
  public static void Main(string[] args)
  {
    int score = 1;
    Console.WriteLine(score);

    while (score < MAX)
    {
      score = int.Parse(Console.ReadLine());
      if (score == MAX) return;

      Console.Clear();

      int rest = MAX - score;
      if (rest <= 2)
        score = MAX;
      else
        score += (score + 1) % 3 == 0 ? 1 : 2;

      Console.WriteLine(score);
    }
  }
}
using System;
class Program
{
  public static void Main(string[] args)
  {
    string[] line = Console.ReadLine().Trim().Split(" ");
    int numCount = int.Parse(line[0]);
    int power = int.Parse(line[1]);

    int[] numbers = new int[numCount];
    for (int i = 0; i < numCount; i++)
      numbers[i] = int.Parse(Console.ReadLine());

    Console.WriteLine(PowerOfTwo(numbers) >= power ? 1 : 0);
  }

  static int PowerOfTwo(int[] numbers)
  {
    int divByTwo = 0;
    foreach (int num in numbers)
    {
      int curNum = num;
      while(curNum % 2 == 0)
      {
        divByTwo++;
        curNum /= 2;
      }
    }
    return divByTwo;
  }
}
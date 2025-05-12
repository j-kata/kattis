using System;
using System.Numerics;
class Program
{
  public static void Main(string[] args)
  {
    string[] numbers = Console.ReadLine().Trim().Split(" ");
    int rowNum = int.Parse(numbers[0]);
    int divider = int.Parse(numbers[1]);
    Console.WriteLine(FindDivisibleInRows(rowNum, divider));
  }

  static long FindDivisibleInRows(int rowNum, int divider)
  {
    int counter = 0;
    BigInteger[] row = {1};

    for (int i = 0; i <= rowNum; i++)
    {
      for (int j = 0; j < row.Length; j++)
        if (row[j] % divider == 0) counter++;

      BigInteger[] nextRow = new BigInteger[row.Length + 1];
      nextRow[0] = 1;
      nextRow[^1] = 1;
      for (int j = 1; j < row.Length; j++) {
        nextRow[j] = row[j] + row[j - 1];
      }
      row = nextRow;
    }
    return counter;
  }
}
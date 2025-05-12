using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    string[] input = Console.ReadLine().Split(" ");
    int n = int.Parse(input[0]);
    int[] array = input[1..].Select(el => int.Parse(el)).ToArray();

    int[] maxLeft = MaxLeft(n, array);
    int[] minRight = MinRight(n, array);

    List<int> pivots = Pivots(array, maxLeft, minRight);

    Console.WriteLine($"{pivots.Count} {string.Join(" ", pivots.Take(100))}");
  }

  static int[] MaxLeft(int size, int[] arr)
  {
    var lefts = new int[size];
    lefts[0] = arr[0];
    for (int i = 1; i < size; i++)
    {
      lefts[i] = Math.Max(lefts[i - 1], arr[i]);
    }
    return lefts;
  }

  static int[] MinRight(int size, int[] arr)
  {
    var rights = new int[size];
    rights[size - 1] = int.MaxValue;
    for (int i = size - 2; i >= 0; i--)
    {
      rights[i] = Math.Min(rights[i + 1], arr[i + 1]);
    }
    return rights;
  }

  static List<int> Pivots(int[] arr, int[] lefts, int[] rights)
  {
    List<int> pivots = new();
    for (int i = 0; i < arr.Length; i++)
    {
      if (lefts[i] <= arr[i] && arr[i] < rights[i])
      {
        pivots.Add(arr[i]);
      }
    }
    return pivots;
  }
}

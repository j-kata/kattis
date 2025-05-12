using System;

class Program
{
  enum SortingOrder
  {
    INCREASING,
    DECREASING,
    NEITHER
  }
  static void Main(string[] args)
  {
    int teamNum = int.Parse(Console.ReadLine());
    string[] teamMembers = new string[teamNum];

    for (int i = 0; i < teamNum; i++)
      teamMembers[i] = Console.ReadLine();

    SortingOrder order = compare(teamMembers[0], teamMembers[1]);
    for (int i = 2; i < teamNum; i++)
    {
        SortingOrder currentOrder = compare(teamMembers[i - 1], teamMembers[i]);
        if (order != currentOrder) {
          order = SortingOrder.NEITHER;
          break;
        }
    }
    Console.WriteLine(order.ToString());
  }

  static SortingOrder compare(string prev, string next)
  {
    int comparison = string.Compare(prev, next, comparisonType: StringComparison.OrdinalIgnoreCase);
    return comparison < 0 ? SortingOrder.INCREASING : SortingOrder.DECREASING; // Equals are not allowed
  }
}
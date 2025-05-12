using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

/******************************************************************************
* |beginning|tail|
* |****|beginning|--tail
* |encodedLetters|
*******************************************************************************/

class Program
{
  private const int LETTERS = 26;

  static void Main(string[] args)
  {
    string[] line = Console.ReadLine().Trim().Split(" ");
    int keyLen = int.Parse(line[0]);
    int textLen = int.Parse(line[1]);

    string knownTail = Console.ReadLine().Trim();
    string encrypted = Console.ReadLine().Trim();

    Console.WriteLine(Decode(encrypted, knownTail));
  }

  static string Decode(string encrypted, string knownTail)
  {
    StringBuilder builder = new(knownTail);
    int end = encrypted.Length;
    int len = knownTail.Length;
    while (builder.Length < encrypted.Length)
    {
      string decoded = DecodePart(encrypted, builder.ToString(), end, len);
      builder.Insert(0, decoded);
      end -= decoded.Length;
    }
    int textStart = builder.Length - encrypted.Length;
    return builder.ToString()[textStart..]; // in case it includes part of keyword
  }

  static string DecodePart(string encrypted, string knownTail, int end, int len)
  {
    int start = end - len;
    StringBuilder builder = new();
    for (int i = start, j = 0; i < end; i++, j++)
    {
      char letter = (char)('a' + (encrypted[i] + LETTERS - knownTail[j]) % LETTERS);
      builder.Append(letter);
    }
    return builder.ToString();
  }
}
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
class Program
{
  static readonly Dictionary<char,string> dictionary = new Dictionary<char, string>{
    {'a',"@"}, {'b',"8"}, {'c',"("}, {'d',"|)"}, {'e',"3"}, {'f',"#"}, {'g',"6"}, {'h',"[-]"}, {'i',"|"}, {'j',"_|"}, {'k',"|<"},
    {'l', "1"}, {'m', "[]\\/[]"}, {'n', "[]\\[]"}, {'o', "0"}, {'p', "|D"}, {'q', "(,)"}, {'r', "|Z"}, {'s', "$"}, {'t', "']['"},
    {'u', "|_|"}, {'v', "\\/"}, {'w', "\\/\\/"}, {'x', "}{"}, {'y', "`/"}, {'z', "2"}
  };
  static void Main(string[] args)
  {
    string text = Console.ReadLine().Trim().ToLower();
    Console.WriteLine(Translate(text));
  }

  static string Translate(string text)
  {
    StringBuilder builder = new StringBuilder();
    foreach (char ch in text)
    {
      if (dictionary.ContainsKey(ch)) {
        builder.Append(dictionary[ch]);
      } else {
        builder.Append(ch);
      }
    }
    return builder.ToString();
  }
}
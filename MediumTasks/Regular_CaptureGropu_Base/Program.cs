
using System.Text.RegularExpressions;

//В этом примере 2 группы, 0 группа - это весь шаблон, 1 группа, та которая вошла в скобки(). Происходит
//поиск идентичной первой группы
string pattern = @"(\w)\1";
string input = "trellis llama webbing dresser swagger";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine("Found '{0}' at position {1}.",
                      match.Value, match.Index);


Console.ReadLine();



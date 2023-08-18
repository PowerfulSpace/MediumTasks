
using System.Text.RegularExpressions;

string pattern = @"(\w)\1";
string input = "trellis llama webbing dresser swagger";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine("Found '{0}' at position {1}.",
                      match.Value, match.Index);


Console.ReadLine();



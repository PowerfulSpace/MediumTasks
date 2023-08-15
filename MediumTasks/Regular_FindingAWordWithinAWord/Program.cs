
using System.Text.RegularExpressions;

string input = "equity queen equip acquaint quiet";
string pattern = @"\Bqu\w+";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine("'{0}' found at position {1}",
                      match.Value, match.Index);

Console.ReadLine();

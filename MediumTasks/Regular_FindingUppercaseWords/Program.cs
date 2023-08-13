
using System.Text.RegularExpressions;

string pattern = @"\b[A-Z]\w*\b";
string input = "A city Albany Zulu maritime Marseilles";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine(match.Value);

Console.ReadLine();


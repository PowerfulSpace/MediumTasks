

using System.Text.RegularExpressions;

string pattern = @"\b[A-Z]+\b(?=\P{P})";
string input = "If so, what comes next?";
foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
    Console.WriteLine(match.Value);

Console.ReadLine();



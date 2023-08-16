
using System.Text.RegularExpressions;

string pattern = @"\b\w+\b(?!\p{P})";
string input = "Disconnected, disjointed thoughts in a sentence fragment.";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine(match.Value);

Console.ReadLine();



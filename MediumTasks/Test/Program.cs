

using System.Text.RegularExpressions;

string input = "This this word Sentence name Capital";
string pattern = @"\b\p{Lu}\w*\b";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine(match.Value);

Console.WriteLine();

pattern = @"\b\p{Lu}(?>\w*)\b";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine(match.Value);

Console.ReadLine();





using System.Text.RegularExpressions;

string input = "needing a reed";
string pattern = @"e{2}\w\b";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine("{0} found at position {1}",
                      match.Value, match.Index);

Console.ReadLine();



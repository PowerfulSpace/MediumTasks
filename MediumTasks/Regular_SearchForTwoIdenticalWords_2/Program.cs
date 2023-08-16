
using System.Text.RegularExpressions;

string pattern = @"(?<duplicateWord>\w+)\s\k<duplicateWord>\W(?<nextWord>\w+)";
string input = "He said that that was the the correct answer.";
foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
    Console.WriteLine("A duplicate '{0}' at position {1} is followed by '{2}'.",
                      match.Groups["duplicateWord"].Value, match.Groups["duplicateWord"].Index,
                      match.Groups["nextWord"].Value);

Console.ReadLine();

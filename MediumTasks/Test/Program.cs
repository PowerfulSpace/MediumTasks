

using System.Text.RegularExpressions;



string pattern = @"\bthe\w*\b";
string input = "The man then told them about that event.";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine("Found {0} at index {1}.", match.Value, match.Index);

Console.WriteLine();
foreach (Match match in Regex.Matches(input, pattern,
                                      RegexOptions.IgnoreCase))
    Console.WriteLine("Found {0} at index {1}.", match.Value, match.Index);


Console.ReadLine();



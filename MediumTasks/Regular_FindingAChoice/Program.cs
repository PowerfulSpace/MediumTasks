
using System.Text.RegularExpressions;

string input = "Brooklyn Dodgers, National League, 1911, 1912, 1932-1957\n" +
                     "Chicago Cubs, National League, 1903-present\n" +
                     "Detroit Tigers, American League, 1901-present\n" +
                     "New York Giants, National League, 1885-1957\n" +
                     "Washington Senators, American League, 1901-1960\n";
string pattern = @"^((\w+(\s?)){2,}),\s(\w+\s\w+),(\s\d{4}(-(\d{4}|present))?,?)+";
Match match;

match = Regex.Match(input, pattern);
while (match.Success)
{
    Console.Write("The {0} played in the {1} in",
                      match.Groups[1].Value, match.Groups[4].Value);
    foreach (Capture capture in match.Groups[5].Captures)
        Console.Write(capture.Value);

    Console.WriteLine(".");
    match = match.NextMatch();
}

Console.WriteLine();

match = Regex.Match(input, pattern, RegexOptions.Multiline);
while (match.Success)
{
    Console.Write("The {0} played in the {1} in",
                      match.Groups[1].Value, match.Groups[4].Value);
    foreach (Capture capture in match.Groups[5].Captures)
        Console.Write(capture.Value);

    Console.WriteLine(".");
    match = match.NextMatch();
}
Console.WriteLine();

Console.ReadLine();


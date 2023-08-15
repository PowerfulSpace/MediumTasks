
using System.Text.RegularExpressions;

string[] inputs = { "Brooklyn Dodgers, National League, 1911, 1912, 1932-1957",
                          "Chicago Cubs, National League, 1903-present" + Environment.NewLine,
                          "Detroit Tigers, American League, 1901-present" + Regex.Unescape(@"\n"),
                          "New York Giants, National League, 1885-1957",
                          "Washington Senators, American League, 1901-1960" + Environment.NewLine};
string pattern = @"^((\w+(\s?)){2,}),\s(\w+\s\w+),(\s\d{4}(-(\d{4}|present))?,?)+\r?\Z";

foreach (string input in inputs)
{
    Console.WriteLine(Regex.Escape(input));
    Match match = Regex.Match(input, pattern);
    if (match.Success)
        Console.WriteLine("   Match succeeded.");
    else
        Console.WriteLine("   Match failed.");
}

Console.ReadLine();


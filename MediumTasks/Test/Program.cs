
using System.Text.RegularExpressions;

string input = "2010 1999 1861 2140 2009";
string pattern = @"(?<=\b20)\d{2}\b";

foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine(match.Value);

Console.ReadLine();



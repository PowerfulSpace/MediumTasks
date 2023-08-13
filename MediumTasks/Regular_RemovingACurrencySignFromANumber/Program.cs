
using System.Text.RegularExpressions;

string pattern = @"(\P{Sc})+";

string[] values = { "$164,091.78", "£1,073,142.68", "73¢", "€120" };
foreach (string value in values)
    Console.WriteLine(Regex.Match(value, pattern).Value);

Console.ReadLine();

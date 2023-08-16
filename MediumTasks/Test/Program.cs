﻿
using System.Text.RegularExpressions;

string[] dates = { "Monday February 1, 2010",
                         "Wednesday February 3, 2010",
                         "Saturday February 6, 2010",
                         "Sunday February 7, 2010",
                         "Monday, February 8, 2010" };
string pattern = @"(?<!(Saturday|Sunday) )\b\w+ \d{1,2}, \d{4}\b";

foreach (string dateValue in dates)
{
    Match match = Regex.Match(dateValue, pattern);
    if (match.Success)
        Console.WriteLine(match.Value);
}
Console.ReadLine();



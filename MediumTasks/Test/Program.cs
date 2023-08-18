

using System.Text.RegularExpressions;


string pattern = "(?s)^.+";
string input = "This is one line and" + Environment.NewLine + "this is the second.";

foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine(Regex.Escape(match.Value));


Console.ReadLine();



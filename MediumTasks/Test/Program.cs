
using System.Text.RegularExpressions;

string pattern = @"\b[A-Z](\w*?\s*?){1,10}[.!?]";
string input = "Hi. I am writing a short note. Its purpose is " +
                      "to test a regular expression that attempts to find " +
                      "sentences with ten or fewer words. Most sentences " +
                      "in this note are short.";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine("'{0}' found at position {1}.", match.Value, match.Index);


Console.ReadLine();



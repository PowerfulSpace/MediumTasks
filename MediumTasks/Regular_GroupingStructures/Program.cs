
using System.Text.RegularExpressions;

string pattern = @"(\b(\w+)\W+)+";
string input = "This is a short sentence.";
Match match = Regex.Match(input, pattern);
Console.WriteLine("Match: '{0}'", match.Value);
for (int ctr = 1; ctr < match.Groups.Count; ctr++)
{
    Console.WriteLine("   Group {0}: '{1}'", ctr, match.Groups[ctr].Value);
    int capCtr = 0;
    foreach (Capture capture in match.Groups[ctr].Captures)
    {
        Console.WriteLine("      Capture {0}: '{1}'", capCtr, capture.Value);
        capCtr++;
    }
}


Console.ReadLine();





using System.Text.RegularExpressions;

string input = "This is the first sentence. Is it the beginning " +
                       "of a literary masterpiece? I think not. Instead, " +
                       "it is a nonsensical paragraph.";
string pattern = @"(?n)\b\(?((?>\w+),?\s?)+[\.!?]\)?";

foreach (Match match in Regex.Matches(input, pattern))
{
    Console.WriteLine("The match: {0}", match.Value);
    int groupCtr = 0;
    foreach (Group group in match.Groups)
    {
        Console.WriteLine("   Group {0}: {1}", groupCtr, group.Value);
        groupCtr++;
        int captureCtr = 0;
        foreach (Capture capture in group.Captures)
        {
            Console.WriteLine("      Capture {0}: {1}", captureCtr, capture.Value);
            captureCtr++;
        }
    }
}

Console.ReadLine();



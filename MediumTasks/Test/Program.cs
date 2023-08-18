
using System.Text.RegularExpressions;

string pattern = @"\b(\p{Lu}{2})(\d{2})?(\p{Lu}{2})\b";
string[] inputs = { "AA22ZZ", "AABB" };
foreach (string input in inputs)
{
    Match match = Regex.Match(input, pattern);
    if (match.Success)
    {
        Console.WriteLine("Match in {0}: {1}", input, match.Value);
        if (match.Groups.Count > 1)
        {
            for (int ctr = 1; ctr <= match.Groups.Count - 1; ctr++)
            {
                if (match.Groups[ctr].Success)
                    Console.WriteLine("Group {0}: {1}",
                                      ctr, match.Groups[ctr].Value);
                else
                    Console.WriteLine("Group {0}: <no match>", ctr);
            }
        }
    }
    Console.WriteLine();
}


Console.ReadLine();



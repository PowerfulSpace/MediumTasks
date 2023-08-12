
using System.Text.RegularExpressions;



string pattern = @"(\d{3})-(\d{3}-\d{4})";
string input = "212-555-6666 906-932-1111 415-222-3333 425-888-9999";
MatchCollection matches = Regex.Matches(input, pattern);

foreach (Match match in matches)
{
    Console.WriteLine("Full telephone number: {0}", match);
    Console.WriteLine("Area Code:             {0}", match.Groups[1].Value);
    Console.WriteLine("Telephone number:      {0}", match.Groups[2].Value);
    Console.WriteLine();
}
Console.WriteLine();


Console.ReadLine();



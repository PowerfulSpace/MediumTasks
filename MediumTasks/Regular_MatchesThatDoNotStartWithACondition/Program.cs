
using System.Text.RegularExpressions;

string pattern = @"\b(?!un)\w+\b";
string input = "unite one unethical ethics use untie ultimate";
foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
    Console.WriteLine(match.Value);

Console.ReadLine();



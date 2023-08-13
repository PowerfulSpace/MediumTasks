
using System.Text.RegularExpressions;



string pattern = @"\bth[^o]\w+\b";
string input = "thought thing though them through thus thorough this";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine(match.Value);



Console.ReadLine();

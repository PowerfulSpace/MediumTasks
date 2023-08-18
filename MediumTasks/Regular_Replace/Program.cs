
using System.Text.RegularExpressions;

string pattern = @"\p{Sc}*(\s?\d+[.,]?\d*)\p{Sc}*";
string replacement = "$1";
string input = "$16.32 12.19 £16.29 €18.29  €18,29";
string result = Regex.Replace(input, pattern, replacement);
Console.WriteLine(result);

Console.ReadLine();



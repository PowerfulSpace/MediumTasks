
using System.Text.RegularExpressions;

string pattern = @"\p{Sc}*(?<amount>\s?\d+[.,]?\d*)\p{Sc}*";
string replacement = "${amount}";
string input = "$16.32 12.19 £16.29 €18.29  €18,29";
string result = Regex.Replace(input, pattern, replacement);
Console.WriteLine(result);

Console.ReadLine();



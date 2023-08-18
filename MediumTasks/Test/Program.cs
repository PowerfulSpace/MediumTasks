

using System.Text.RegularExpressions;

string pattern = @"\b\d+\.\d{2}\b";
string replacement = "$$$&";
string input = "Total Cost: 103.64";
Console.WriteLine(Regex.Replace(input, pattern, replacement));
Console.ReadLine();



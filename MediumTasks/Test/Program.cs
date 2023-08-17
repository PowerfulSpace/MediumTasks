
using System.Text.RegularExpressions;

string pattern = @"\b(\w{3,}?\.){2}?\w{3,}?\b";
string input = "www.microsoft.com msdn.microsoft.com mywebsite mycompany.com";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine("'{0}' found at position {1}.", match.Value, match.Index);


Console.ReadLine();




using System.Text.RegularExpressions;

string greedyPattern = @"\b.*([0-9]{4})\b";
string input1 = "1112223333 3992991999";
foreach (Match match in Regex.Matches(input1, greedyPattern))
    Console.WriteLine("Account ending in ******{0}.", match.Groups[1].Value);



Console.ReadLine();



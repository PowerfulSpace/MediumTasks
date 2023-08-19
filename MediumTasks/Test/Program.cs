

using System.Text.RegularExpressions;


string input = "16.32\n194.03\n1,903,672.08";
string pattern = @"(\d+\.?\,?)+\d+";

Regex regex = new Regex(pattern);
var result = regex.Matches(input);

foreach (Match item in result)
{
    Console.WriteLine(item.Result("$$ $&"));
}

Console.ReadLine();



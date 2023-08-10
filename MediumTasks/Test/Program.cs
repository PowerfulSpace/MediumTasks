
using System.Text.RegularExpressions;



string input = "5 is less than 10";


Regex regex = new Regex(@"^\d+\D*\d+$");

var result = regex.Matches(input);

foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.ReadLine();



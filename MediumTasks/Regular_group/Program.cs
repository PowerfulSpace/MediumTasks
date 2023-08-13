
using System.Text.RegularExpressions;

Console.WriteLine("\n\n\n");
//      группировка телефона по коду региона и самому номеру телефона

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
Console.WriteLine("\n\n\n");


//      группировка по городу стране и количеству проживающих

string delimited = @"\G(.+)[\t\u007c](.+)\r?\n";
string input2 = "Mumbai, India|13,922,125\t\n" +
                      "Shanghai, China\t13,831,900\n" +
                      "Karachi, Pakistan|12,991,000\n" +
                      "Delhi, India\t12,259,230\n" +
                      "Istanbul, Türkiye|11,372,613\n";
Console.WriteLine("Population of the World's Largest Cities, 2009");
Console.WriteLine();
Console.WriteLine("{0,-20} {1,10}", "City", "Population");
Console.WriteLine();
foreach (Match match in Regex.Matches(input2, delimited))
    Console.WriteLine("{0,-20} {1,10}", match.Groups[1].Value,
                                       match.Groups[2].Value);


Console.ReadLine();



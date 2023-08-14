
using System.Text.RegularExpressions;


string pattern = @"^(\(?\d{3}\)?[\s-])?\d{3}-\d{4}$";
string[] inputs = { "111 111-1111", "222-2222", "222 333-444",
                          "(212) 111-1111", "111-AB1-1111",
                          "212-111-1111", "01 999-9999" };

foreach (string input in inputs)
{
    var result = Regex.IsMatch(input, pattern);
    IsValidNumber(result, input);

}
Console.ReadLine();

static void IsValidNumber(bool isMatch, string input)
{
    if (isMatch)
    {
        Console.Write("{0,-15}", input);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("{0}", ": matched");
    }
    else
    {
        Console.Write("{0,-15}", input);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0}", ": match failed");

    }
    Console.ForegroundColor = ConsoleColor.White;
}


using System.Text.RegularExpressions;

string input = "1. Eggs 2. Bread 3. Milk 4. Coffee 5. Tea";
string pattern = @"\b\d{1,2}\.\s";
foreach (string item in Regex.Split(input, pattern))
{
    if (!String.IsNullOrEmpty(item))
        Console.WriteLine(item);
}
Console.ReadLine();



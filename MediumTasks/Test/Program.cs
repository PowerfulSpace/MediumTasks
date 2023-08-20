using System.Text.RegularExpressions;

string testString = "John Doe, 42 years";
Regex regex = new Regex("[0-9]+");
if (regex.IsMatch(testString))
    Console.WriteLine("String contains numbers!");
else
    Console.WriteLine("String does NOT contain numbers!");

Console.ReadLine();

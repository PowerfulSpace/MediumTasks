

using System.Text.RegularExpressions;


string pattern = @"^(\w+\s?)+$";
string[] titles = { "A Tale of Two Cities",
                          "The Hound of the Baskervilles",
                          "The Protestant Ethic and the Spirit of Capitalism",
                          "The Origin of Species" };
string replacement = "\"$&\"";
foreach (string title in titles)
    Console.WriteLine(Regex.Replace(title, pattern, replacement));

Console.ReadLine();



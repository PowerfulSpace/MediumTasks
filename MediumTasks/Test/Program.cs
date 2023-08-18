

using System.Text.RegularExpressions;



string pattern = @"\b(\w+)\s\1\b";
string substitution = "$+";
string input = "The the dog jumped over the fence fence.";
Console.WriteLine(Regex.Replace(input, pattern, substitution,
                  RegexOptions.IgnoreCase));


Console.ReadLine();



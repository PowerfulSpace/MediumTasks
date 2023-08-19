

using System.Text.RegularExpressions;

string greedyPattern = @".+(\d+)\.";
string lazyPattern = @".+?(\d+)\.";
string input = "This sentence ends with the number 107325.";
Match match;

// Match using greedy quantifier .+.
match = Regex.Match(input, greedyPattern);
if (match.Success)
    Console.WriteLine("Number at end of sentence (greedy): {0}",
                      match.Groups[1].Value);
else
    Console.WriteLine("{0} finds no match.", greedyPattern);

// Match using lazy quantifier .+?.
match = Regex.Match(input, lazyPattern);
if (match.Success)
    Console.WriteLine("Number at end of sentence (lazy): {0}",
                      match.Groups[1].Value);
else
    Console.WriteLine("{0} finds no match.", lazyPattern);

Console.ReadLine();



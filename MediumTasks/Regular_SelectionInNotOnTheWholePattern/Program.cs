using System.Text.RegularExpressions;

string pattern = @"\b\w+(?=\sis\b)";
string[] inputs = { "The dog is a Malamute.",
                          "The island has beautiful birds.",
                          "The pitch missed home plate.",
                          "Sunday is a weekend day." };

foreach (string input in inputs)
{
    Match match = Regex.Match(input, pattern);
    if (match.Success)
        Console.WriteLine("'{0}' precedes 'is'.", match.Value);
    else
        Console.WriteLine("'{0}' does not match the pattern.", input);
}

Console.ReadLine();



//Делает одну общую группировку благодаря :?
//
//string pattern = @"(?:\b(?:\w+)\W*)+\.";
//string input = "This is a short sentence.";
//Match match = Regex.Match(input, pattern);
//Console.WriteLine("Match: {0}", match.Value);
//for (int ctr = 1; ctr < match.Groups.Count; ctr++)
//    Console.WriteLine("   Group {0}: {1}", ctr, match.Groups[ctr].Value);


//Убирает чувствительность к регистру
//
//string pattern = @"\b(?ix: d \w+)\s";
//string input = "Dogs are decidedly good pets.";

//foreach (Match match in Regex.Matches(input, pattern))
//    Console.WriteLine("'{0}// found at index {1}.", match.Value, match.Index);
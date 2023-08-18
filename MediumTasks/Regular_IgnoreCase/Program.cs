

using System.Text.RegularExpressions;

string pattern = @"\b(?ix: d \w+)\s";
string input = "Dogs are decidedly good pets.";

foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine("'{0}// found at index {1}.", match.Value, match.Index);


//Игнорирование регистра только буквы t, такие буквы he не попадут под возможность не учитывания регистра
string pattern2 = @"\b(?i:t)he\w*\b";
string input2 = "The man then told them about that event.";
foreach (Match match in Regex.Matches(input2, pattern2))
    Console.WriteLine("Found {0} at index {1}.", match.Value, match.Index);

Console.WriteLine();
string pattern3 = @"(?i)\bthe\w*\b";
foreach (Match match in Regex.Matches(input2, pattern3,
                                      RegexOptions.IgnoreCase))
    Console.WriteLine("Found {0} at index {1}.", match.Value, match.Index);

Console.ReadLine();



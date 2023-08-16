
using System.Text.RegularExpressions;

//Находит слова которые не начинаются на un
string pattern = @"\b(?!un)\w+\b";
string input = "unite one unethical ethics use untie ultimate";
foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
    Console.WriteLine(match.Value);
Console.WriteLine();

//Находит слова которые не заканчиваются знаками припинания
string pattern2 = @"\b\w+\b(?!\p{P})";
string input2 = "Disconnected, disjointed thoughts in a sentence fragment.";
foreach (Match match in Regex.Matches(input2, pattern2))
    Console.WriteLine(match.Value);
Console.WriteLine();

//Выбирает часть которая не подверглась ретроспективе ?<=
string input3 = "2010 1999 1861 2140 2009";
string pattern3 = @"(?<=\b20)\d{2}\b";
foreach (Match match in Regex.Matches(input3, pattern3))
    Console.WriteLine(match.Value);
Console.WriteLine();

//Выбирает те предложения перед которыми не стоит слово Saturday или Sunday
string[] dates4 = { "Monday February 1, 2010",
                         "Wednesday February 3, 2010",
                         "Saturday February 6, 2010",
                         "Sunday February 7, 2010",
                         "Monday, February 8, 2010" };
string pattern4 = @"(?<!(Saturday|Sunday) )\b\w+ \d{1,2}, \d{4}\b";

foreach (string dateValue in dates4)
{
    Match match = Regex.Match(dateValue, pattern4);
    if (match.Success)
        Console.WriteLine(match.Value);
}
Console.WriteLine();


Console.ReadLine();



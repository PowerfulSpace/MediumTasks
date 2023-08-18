﻿
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

//Находит слова с заглавной буквой
string input5 = "This this word Sentence name Capital";
string pattern5 = @"\b\p{Lu}\w*\b";
foreach (Match match in Regex.Matches(input5, pattern5))
    Console.WriteLine(match.Value);

Console.WriteLine();

//Группа без захвата, которая отбрасывает позиции возврата после совпадения
string pattern6 = @"\b\p{Lu}(?>\w*)\b";
foreach (Match match in Regex.Matches(input5, pattern6))
    Console.WriteLine(match.Value);

//Отключает группу захвата подстрок ?:
string input7 = "This is one sentence. This is another.";
string pattern7 = @"\b(?:\w+[;,]?\s?)+[.?!]";

foreach (Match match in Regex.Matches(input7, pattern7))
{
    Console.WriteLine("Match: '{0}' at index {1}.",
                      match.Value, match.Index);
    int grpCtr = 0;
    foreach (Group grp in match.Groups)
    {
        Console.WriteLine("   Group {0}: '{1}' at index {2}.",
                          grpCtr, grp.Value, grp.Index);
        int capCtr = 0;
        foreach (Capture cap in grp.Captures)
        {
            Console.WriteLine("      Capture {0}: '{1}' at {2}.",
                              capCtr, cap.Value, cap.Index);
            capCtr++;
        }
        grpCtr++;
    }


    Console.ReadLine();



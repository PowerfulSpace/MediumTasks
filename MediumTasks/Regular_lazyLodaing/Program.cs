﻿
using System.Text.RegularExpressions;

//Без ленивого совпадения не корректно отрабатывает код
string regexp = @""".+?"" ";
string str = "a \"witch\" and her \"broom\" is one";
Regex regex = new Regex(regexp);
var result = regex.Matches(str);

foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.WriteLine();

//Демонстративно показано как рабоатет ленивое совпадение
string pattern = @"^\s*(System.)??Console.Write(Line)??\(??";
string input = "System.Console.WriteLine(\"Hello!\")\n" +
                      "Console.Write(\"Hello!\")\n" +
                      "Console.WriteLine(\"Hello!\")\n" +
                      "Console.ReadLine()\n" +
                      "   Console.WriteLine";

Console.WriteLine();
foreach (Match match in Regex.Matches(input, pattern,
                                      RegexOptions.IgnorePatternWhitespace |
                                      RegexOptions.IgnoreCase |
                                      RegexOptions.Multiline))
    Console.WriteLine("'{0}' found at position {1}.", match.Value, match.Index);
Console.WriteLine();

//Поиск паттерна сайта
string pattern2 = @"\b(\w{3,}?\.){2}?\w{3,}?\b";
string input2 = "www.microsoft.com msdn.microsoft.com mywebsite mycompany.com";
foreach (Match match in Regex.Matches(input2, pattern2))
    Console.WriteLine("'{0}' found at position {1}.", match.Value, match.Index);
Console.WriteLine();

//Поиск предложений которые включат в себя не более 10 слов
string pattern3 = @"\b[A-Z](\w*?\s*?){1,10}[.!?]";
string input3 = "Hi. I am writing a short note. Its purpose is " +
                      "to test a regular expression that attempts to find " +
                      "sentences with ten or fewer words. Most sentences " +
                      "in this note are short.";
foreach (Match match in Regex.Matches(input3, pattern3))
    Console.WriteLine("'{0}' found at position {1}.", match.Value, match.Index);
Console.WriteLine();

//Выбор строк с ленивым совпадением
string greedyPattern = @"\b.*([0-9]{4})\b";
string input4 = "1112223333 3992991999";
foreach (Match match in Regex.Matches(input4, greedyPattern))
    Console.WriteLine("Account ending in ******{0}.", match.Groups[1].Value);


Console.ReadLine();

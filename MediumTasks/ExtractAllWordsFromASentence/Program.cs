﻿

using System.Text.RegularExpressions;

string text = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";

Regex regex = new Regex(@"[а-яА-Я]\w*\D?\s?");

MatchCollection result = regex.Matches(text);

if (result.Count > 0)
{
    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
}



Console.ReadLine();

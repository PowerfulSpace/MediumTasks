
using System.Text;
using System.Text.RegularExpressions;

//Выделить тегом<strong> повторяющиеся слова.

string text =
    "В этот лес лес завороженный,\r\n" +
    "По пушинкам серебра серебра,\r\n" +
    "Я с винтовкой заряженной\r\n" +
    "На охоту охоту шел вчера.\r\n" +
    "По дорожке чистой, гладкой\r\n" +
    "Я прошел, не наследил наследил…";

string patternAllString = @"^.+";
Regex regexAllString = new Regex(patternAllString, RegexOptions.Multiline);
var result = regexAllString.Matches(text);

string patternSameWords = @"(\w+\s)\1+";
Regex regexSameWords = new Regex(patternSameWords);

StringBuilder editText = new StringBuilder();

foreach (Match item in result)
{
    var r = regexSameWords.Replace(item.Value, $"<string>{(regexSameWords.Match(item.Value).Groups[1]).ToString().Trim()}</string> ");
    editText.AppendLine(r);
}

Console.WriteLine(text);
Console.WriteLine();
Console.WriteLine(editText);


Console.ReadLine();


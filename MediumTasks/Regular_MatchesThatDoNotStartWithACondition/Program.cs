
using System.Text.RegularExpressions;

//Находит слова которые не начинаются на un
string pattern = @"\b(?!un)\w+\b";
string input = "unite one unethical ethics use untie ultimate";
foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
    Console.WriteLine(match.Value);

//Находит слова которые не заканчиваются знаками припинания
string pattern2 = @"\b\w+\b(?!\p{P})";
string input2 = "Disconnected, disjointed thoughts in a sentence fragment.";
foreach (Match match in Regex.Matches(input2, pattern2))
    Console.WriteLine(match.Value);

Console.ReadLine();



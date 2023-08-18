
using System.Text.RegularExpressions;

//В этом примере 2 группы, 0 группа - это весь шаблон, 1 группа, та которая вошла в скобки(). Происходит
//поиск идентичной первой группы ( тоесть, сопоставляет символ \w)
string pattern = @"(\w)\1";
string input = "trellis llama webbing dresser swagger";
foreach (Match match in Regex.Matches(input, pattern))
    Console.WriteLine("Found '{0}' at position {1}.",
                      match.Value, match.Index);


//Работает как и предыдущий пример. Сдесь используется имя захватываемой группу ?<char> - имя char( может быть любое)
//И сопоставляем с помощи имя для одинакового поиска
string pattern2 = @"(?<char>\w)\k<char>";
string input2 = "trellis llama webbing dresser swagger";
foreach (Match match in Regex.Matches(input2, pattern2))
    Console.WriteLine("Found '{0}' at position {1}.",
                      match.Value, match.Index);


//uгруппы захвата. a совпадает с a и дописываем b. Первая группа захвата
string pattern3 = @"(?<1>a)(?<1>\1b)*";
string input3 = "aababb";
foreach (Match match in Regex.Matches(input3, pattern3))
{
    Console.WriteLine("Match: " + match.Value);
    foreach (Group group in match.Groups)
        Console.WriteLine("   Group: " + group.Value);
}


//сопоставление шаблона с группами захвата. \p{Lu} -  заглавные буквы
string pattern4 = @"\b(\p{Lu}{2})(\d{2})?(\p{Lu}{2})\b";
string[] inputs4 = { "AA22ZZ", "AABB" };
foreach (string input4 in inputs4)
{
    Match match = Regex.Match(input4, pattern4);
    if (match.Success)
    {
        Console.WriteLine("Match in {0}: {1}", input4, match.Value);
        if (match.Groups.Count > 1)
        {
            for (int ctr = 1; ctr <= match.Groups.Count - 1; ctr++)
            {
                if (match.Groups[ctr].Success)
                    Console.WriteLine("Group {0}: {1}",
                                      ctr, match.Groups[ctr].Value);
                else
                    Console.WriteLine("Group {0}: <no match>", ctr);
            }
        }
    }
    Console.WriteLine();
}


Console.ReadLine();



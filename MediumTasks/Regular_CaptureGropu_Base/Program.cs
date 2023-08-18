
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




Console.ReadLine();



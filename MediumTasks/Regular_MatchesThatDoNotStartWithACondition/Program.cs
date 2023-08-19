
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

}

//$$ - Знак доллара ($). $& - Вся совпавшая подстрока.
string pattern8 = @"\b\d+\.\d{2}\b";
string replacement8 = "$$$&";
string input8 = "Total Cost: 103.64";
Console.WriteLine(Regex.Replace(input8, pattern8, replacement8));


//Удаляем символы, совпавшие с паттерном. И возвращаем массив данных
string input9 = "1. Eggs 2. Bread 3. Milk 4. Coffee 5. Tea";
string pattern9 = @"\b\d{1,2}\.\s";
foreach (string item in Regex.Split(input9, pattern9))
{
    if (!String.IsNullOrEmpty(item))
        Console.WriteLine(item);
}

//подставляем сиволы доллора к найденному патерну
string input10 = "16.32\n194.03\n1,903,672.08";
string pattern10 = @"(\d+\.?\,?)+\d+";

Regex regex = new Regex(pattern10);
var result = regex.Matches(input10);

foreach (Match item in result)
{
    Console.WriteLine(item.Result("$$ $&"));
}

//Именнованная группа захвата. И обращение по ключу
var r = new Regex(@"^(?<name>\w+):(?<value>\w+)");
Match m = r.Match("Section1:119900");
Console.WriteLine(m.Groups["name"].Value);
Console.WriteLine(m.Groups["value"].Value);

//Если следующий символ не является знаком припинания, тогда ок
string pattern11 = @"\b[A-Z]+\b(?=\P{P})";
string input11 = "If so, what comes next?";
foreach (Match match in Regex.Matches(input11, pattern11, RegexOptions.IgnoreCase))
    Console.WriteLine(match.Value);



Console.ReadLine();



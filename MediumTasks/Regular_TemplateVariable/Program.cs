
using System.Text.RegularExpressions;



string input = "02/05/1982";

var result = Regex.Replace(input,
    @"(?<Месяц>\d{1,2})/(?<День>\d{1,2})/(?<Год>\d{2,4})",
    "${День}-${Месяц}-${Год}");


Console.WriteLine(input);
Console.WriteLine(result);


//string input = "У лукоморья дуб зелёный;\r\n" +
//    "Златая цепь на дубе том:\r\n" +
//    "И днём и ночью кот учёный\r\n" +
//    "Всё ходит по цепи кругом;";


//var result = Regex.Replace(input,
//    @"У (?<var1>\w+) (?<var2>\w+) зелёный",
//    "У ${var2} ${var1} зелёный");


//Console.WriteLine(input);
//Console.WriteLine();
//Console.WriteLine(result);


Console.ReadLine();




using System.Text.RegularExpressions;



string input = "02/05/1982";

var result = Regex.Replace(input,
    @"(?<Месяц>\d{1,2})/(?<День>\d{1,2})/(?<Год>\d{2,4})",
    "${День}-${Месяц}-${Год}");


Console.WriteLine(input);
Console.WriteLine(result);


Console.ReadLine();



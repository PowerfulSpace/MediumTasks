
using System.Text.RegularExpressions;



string input = "5 is less than 10";


var result = Regex.Replace(input,
    @"\d+",
    x => (int.Parse(x.Value) + 1).ToString());


Console.WriteLine(input);
Console.WriteLine();
Console.WriteLine(result);



Console.ReadLine();



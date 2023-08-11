
using System.Text.RegularExpressions;



string input = "Once upon a time there was a poor miller." +
    " He lived in a small house, together with his three sons." +
    " The miller worked at the mill, and his sons helped him." +
    " The miller had no horse." +
    " He used his donkey to bring wheat from the fields.";


Regex regex = new Regex(@"[a-zA-Z ]+\.");
var result = regex.Matches(input);


Regex regex2 = new Regex("miller|small");
List<string> coincidences = new List<string>();


for (int i = 0; i < result.Count; i++)
{
    Console.WriteLine(result[i]);
    if (regex2.IsMatch(result[i].Value))
    {
        coincidences.Add(result[i].Value);
    }
}

Console.WriteLine();
foreach (var item in coincidences)
{
    Console.WriteLine(item);
}


Console.ReadLine();



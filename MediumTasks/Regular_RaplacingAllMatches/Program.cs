

using System.Text.RegularExpressions;

//устанавливает в начале и в конце строки ковычки. Суть $& - используеи все совпадения строки
string pattern = @"^(\w+\s?)+$";
string[] titles = { "A Tale of Two Cities",
                          "The Hound of the Baskervilles",
                          "The Protestant Ethic and the Spirit of Capitalism",
                          "The Origin of Species" };
string replacement = "\"$&\"";
foreach (string title in titles)
    Console.WriteLine(Regex.Replace(title, pattern, replacement));

//Заменяем повторяющие слова на одно слово
string pattern2 = @"\b(\w+)\s\1\b";
string substitution = "$+";
string input2 = "The the dog jumped over the fence fence.";
Console.WriteLine(Regex.Replace(input2, pattern2, substitution,
                  RegexOptions.IgnoreCase));


Console.ReadLine();



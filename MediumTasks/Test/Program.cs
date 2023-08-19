

using System.Text.RegularExpressions;

var r = new Regex(@"^(?<name>\w+):(?<value>\w+)");
Match m = r.Match("Section1:119900");
Console.WriteLine(m.Groups["name"].Value);
Console.WriteLine(m.Groups["value"].Value);

Console.ReadLine();



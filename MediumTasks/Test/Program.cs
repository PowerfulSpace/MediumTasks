﻿

using System.Text.RegularExpressions;

string url = "http://www.contoso.com:8080/letters/readme.html";

Regex r = new Regex(@"^(?<proto>\w+)://[^/]+?(?<port>:\d+)?/",
                    RegexOptions.None, TimeSpan.FromMilliseconds(150));
Match m = r.Match(url);
if (m.Success)
    Console.WriteLine(m.Result("${proto}${port}"));

Console.ReadLine();


using System.Text.RegularExpressions;

string result = string.Empty;

result = Regex.Replace("04/17/2012",
                        "(?<month>\\d{1,2})/(?<day>\\d{1,2})/(?<year>\\d{2,4})",
                        "${day}-${month}-${year}");

Console.WriteLine(result);

result = Regex.Replace("@_H e l l o-777.,:;'!@#$%^&*()_-+<>?/",
                      @"[^\w\.@_-]", "");


Console.WriteLine(result);

Console.ReadKey();


Console.ReadLine();

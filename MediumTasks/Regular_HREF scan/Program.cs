

using System.Text.RegularExpressions;


DumpHRefs("https://translate.google.com/?hl=ru&sl=en&tl=ru&text=Thread-safe%20collections&op=translate");
Console.ReadLine();


static void DumpHRefs(string inputString)
{
    string hrefPattern = @"href\s*=\s*(?:[""'](?<1>[^""']*)[""']|(?<1>[^>\s]+))";

    try
    {
        Match regexMatch = Regex.Match(inputString, hrefPattern,
                                       RegexOptions.IgnoreCase | RegexOptions.Compiled,
                                       TimeSpan.FromSeconds(1));
        while (regexMatch.Success)
        {
            Console.WriteLine($"Found href {regexMatch.Groups[1]} at {regexMatch.Groups[1].Index}");
            regexMatch = regexMatch.NextMatch();
        }
    }
    catch (RegexMatchTimeoutException)
    {
        Console.WriteLine("The matching operation timed out.");
    }
}
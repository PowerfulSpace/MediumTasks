

using System.Text.RegularExpressions;


string inputString = "My favorite web sites include:</P>" +
                         "<A HREF=\"https://learn.microsoft.com/en-us/dotnet/\">" +
                         ".NET Documentation</A></P>" +
                         "<A HREF=\"http://www.microsoft.com\">" +
                         "Microsoft Corporation Home Page</A></P>" +
                         "<A HREF=\"https://devblogs.microsoft.com/dotnet/\">" +
                         ".NET Blog</A></P>";
DumpHRefs(inputString);
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


using System.Text.RegularExpressions;


string a = "dsa,d";
Example.CleanInput(a);

Console.ReadLine();

static public class Example
{
    static public string CleanInput(string strIn)
    {
        // Replace invalid characters with empty strings.
        try
        {
            return Regex.Replace(strIn, @"[^\w\.@-]", "",
                                 RegexOptions.None, TimeSpan.FromSeconds(1.5));
        }
        // If we timeout when replacing invalid characters,
        // we should return Empty.
        catch (RegexMatchTimeoutException)
        {
            return String.Empty;
        }
    }
}


using System.Text.RegularExpressions;


SortedList<int, string> scores = new SortedList<int, string>(new DescendingComparer<int>());

string input = "Joe 164\n" +
               "Sam 208\n" +
               "Allison 211\n" +
               "Gwen 171\n";
string pattern = @"(?m)^(\w+)\s(\d+)\r*$";

foreach (Match match in Regex.Matches(input, pattern, RegexOptions.Multiline))
    scores.Add(Convert.ToInt32(match.Groups[2].Value), match.Groups[1].Value);

// List scores in descending order.
foreach (KeyValuePair<int, string> score in scores)
    Console.WriteLine("{0}: {1}", score.Value, score.Key);


//Преобразует текст в одну строку
string pattern2 = "(?s)^.+";
string input2 = "This is one line and" + Environment.NewLine + "this is the second.";

foreach (Match match in Regex.Matches(input2, pattern2))
    Console.WriteLine(Regex.Escape(match.Value));



Console.ReadLine();


public class DescendingComparer<T> : IComparer<T>
{
    public int Compare(T x, T y)
    {
        return Comparer<T>.Default.Compare(x, y) * -1;
    }
}
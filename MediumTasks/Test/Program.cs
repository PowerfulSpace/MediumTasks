

using System.Text.RegularExpressions;

string shablon_email = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
while (true)
{
    Console.WriteLine("Укажите email");
    string email = Console.ReadLine();
    if (Regex.IsMatch(email, shablon_email, RegexOptions.IgnoreCase))
    {
        Console.WriteLine("Адрес электронной почты" + email + " введен верно");
        break;
    }
    else
    {
        Console.WriteLine("Введенный адрес электронной почты " + email + " некорректен");
    }
}

Console.ReadLine();
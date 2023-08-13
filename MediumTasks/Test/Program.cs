
using System.Text.RegularExpressions;


//string pattern = @"gr[ae]y\s\S+?[\s\p{P}]";
//string input = "The gray wolf jumped over the grey wall.";
//MatchCollection matches = Regex.Matches(input, pattern);
//foreach (Match match in matches)
//    Console.WriteLine($"'{match.Value}'");


string input = "\r\nOnce upon a time there was a poor miller. He lived in a small house, together with his three sons. The miller worked at the mill, and his sons helped him. The miller had no horse. He used his donkey to bring wheat from the fields.\r\n\r\nThe years went by. The miller grew old and died. His sons decided to divide their father's things among themselves. That was easy: he had almost nothing to leave to his sons. Only his mill, his donkey and his cat.\r\n\r\n\"I'm going to take the mill,\" said the miller's oldest son.\r\n\r\n\"I'm going to take the donkey,\" said the second.\r\n\r\n\"And what about me?\" asked the youngest son.\r\n\r\n\"You? You can take the cat,\" laughed his brothers.\r\n\r\nThe young fellow was very much upset. He went out of the house and sat down on the bench.\r\n\r\n\"Oh, well,\" he said in a sad voice. \"My brothers have the mill and the donkey. They can put them together and make enough money to live an honest life. But what can I do? I can eat the cat, and I can make a hat out of his fur. But then I have nothing. I can die of hunger.\"\r\n\r\nThe Cat was sitting on the bench too. He was trying not to listen to his master. But of course he heard all his words. And he didn't like them at all. He put on a serious face and said:\r\n\r\n\"Don't look so sad, Master. I'm not a bad thing. And I am more useful to you alive than dead. I can prove that.\"\r\n\r\n\"How so?\" asked the Cat's master.\r\n\r\n\"All you have to do is to give me a bag, and get a pair of boots. Such as gentlemen wear in the woods. I'm going to show you that you're lucky to have me.\"\r\n\r\n\"It's unusual that a cat can speak at all,\" the miller's son said to himself. But then he started thinking. \"This cat's very good at catching rats and mice. He played so many cunning tricks on them. He never came home without a rat or a mouse. He could hide in the wheat, or pretend to be dead. Perhaps, he can help me after all.\"\r\n\r\n\"OK,\" he said to the Cat. \"I'm going now to order the boots.\"";


string pattern = @"\w+\.\r\n";

Regex regex = new Regex(pattern);

var result = regex.Matches(input);

foreach (var item in result)
{
    Console.WriteLine(item);
}

//Console.WriteLine(input);

Console.ReadLine();


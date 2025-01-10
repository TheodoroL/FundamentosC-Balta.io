using System.Text.RegularExpressions;

namespace EditorHtml;

public static class Viewrs
{

    public static void Show(string text)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Modo Vizualiação");
        Line();
        Replace(text);
        Line();
        Menu.Show();

    }


    private static void Line(short count = 20)
    {
        Console.Write("+");
        for (short c = 0; c < count; c++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.WriteLine();

    }

    public static void Replace(string text)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        var words = text.Split(' ');
        for (int c = 0; c < words.Length; c++)
        {
            if (strong.IsMatch(words[c]))
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write(words[c].Substring(words[c].IndexOf('>') + 1, words[c].LastIndexOf('<') - 1 - words[c].IndexOf('>')));
                Console.Write(" ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(words[c]);
                Console.Write(" ");

            }
        }
        Console.ReadKey();

    }
}
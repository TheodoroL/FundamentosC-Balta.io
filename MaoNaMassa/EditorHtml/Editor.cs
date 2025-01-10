using System.Text;

namespace EditorHtml;

public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Modo Editor");
        Line(20);
        Start();
    }
    public static void Start()
    {
        var file = new StringBuilder();
        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);

        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        Line();
        Console.WriteLine("Deseja salvar o arquivo ? [S]/[N]:");

        char v;
        while (!char.TryParse(Console.ReadLine().ToLower(), out v))
        {
            Console.Write("digite [S] ou [N]:");
        }
        if (v == 's')
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "teste.txt");
            using (var files = new StreamWriter(path))
            {
                files.Write(file.ToString());
            }
            Console.WriteLine("salvo com  sucesso");
        }
        Menu.Show();
    }

    public static void Line(short count = 6)
    {
        Console.Write("+");
        for (int c = 0; c < count; c++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.WriteLine();
    }
}
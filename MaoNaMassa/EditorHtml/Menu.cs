
namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOption();
            Console.ResetColor();
            short options = short.Parse(Console.ReadLine());
            HandleMenuOption(options);

        }

        private static void DrawScreen()
        {
            ColumnLines();
            Lines();
            ColumnLines();
        }

        private static void ColumnLines()
        {
            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        private static void Lines()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 38; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
        private static void WriteOption()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        private static void HandleMenuOption(short options)
        {
            switch (options)
            {
                case 1: Editor.Show(); break;
                case 2:
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "teste.txt");
                    string text;

                    using (var file = new StreamReader(path))
                    {
                        text = file.ReadToEnd();
                    }
                    Viewrs.Show(text);
                    break;
                case 0: Console.Clear(); Environment.Exit(0); break;
                default: Show(); break;
            }
        }
    }

}

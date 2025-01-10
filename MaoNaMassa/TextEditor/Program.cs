class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("[0] Sair do Programa");
        Console.WriteLine("[1] Abrir um Arquivo");
        Console.WriteLine("[2] Criar um arquivo");
        Console.Write("->");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Abrir(); break;
            case 2: Editar(); break;
            default: Menu(); break;
        }

    }
    static void Abrir()
    {
        Console.Clear();
        Console.Write("digite o path do arquivo:");
        string path = Console.ReadLine();
        if (string.IsNullOrEmpty(path))
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), "teste.txt");
        }
        using (var file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }
        Console.ReadLine();
        Menu();
    }
    static void Editar()
    {
        Console.Clear();
        Console.WriteLine("digite o seu texto abaixo !! (ESC para sair)");

        Console.Write("->");
        string text = "";

        // enquanto o usuário não apertar ESC, não vai sair desse loop
        do
        {
            text += Console.ReadLine();
            //vai quebrar uma linha no final do texto
            text += Environment.NewLine;

        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
        Salvar(text);
    }
    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual é o caminho que você quer salvar  o arquivo?:");
        string path = Console.ReadLine();
        // se o arquivo for null
        if (string.IsNullOrEmpty(path))
        {
            //path vai ser esse
            path = Path.Combine(Directory.GetCurrentDirectory(), "teste.txt");
        }
        Console.WriteLine(path);
        //se colocar o true no streamWriter, ele não vai apagar o que tiver dentro do arquivo
        using (var file = new StreamWriter(path, true))
        {
            file.Write(text);
        }
        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Menu();
    }
}
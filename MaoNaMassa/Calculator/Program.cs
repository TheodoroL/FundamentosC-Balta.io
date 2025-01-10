namespace Calculator;
class Program
{
    static void Main(string[] args)
    {

        // Soma();
        // Subtracao();
        // Divisao();
        // Multiplicacao();
        Menu();
    }
    static void Soma()
    {
        Console.Clear();
        Console.Write("primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("segundo valor:");
        float v2 = float.Parse(Console.ReadLine());
        float soma = v1 + v2;
        Console.WriteLine($"{v1}+{v2}={soma}");
        // Console.WriteLine($"{v1}+{v2}={v1 + v2}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();
        Console.Write("digite o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("digite o segundo valor valor:");
        float v2 = float.Parse(Console.ReadLine());
        float resultado = v1 - v2;
        Console.WriteLine($"{v1}-{v2}={resultado}");
        //para não fechar o programa de uma vez
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.Write("digite o seu primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("digite o segundo valor :");
        float v2 = float.Parse(Console.ReadLine());
        if (v2 == 0)
        {
            Console.WriteLine("não pode dividir por zero");
        }
        else
        {
            Console.WriteLine($"{v1}/{v2}={v1 / v2}");
        }
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {
        Console.Clear();
        Console.Write("digite o seu primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("digite o segundo valor:");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine($"{v1}*{v2}={v1 * v2}");
        Console.ReadKey();
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("----------------------");
        Console.WriteLine("[1] Soma");
        Console.WriteLine("[2] Subtração");
        Console.WriteLine("[3] Divisão");
        Console.WriteLine("[4] Multiplicação");
        Console.WriteLine("[5] Sair");
        Console.WriteLine("----------------------");
        Console.Write("-> ");
        int res = int.Parse(Console.ReadLine());
        Console.WriteLine(res);

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Console.Clear(); Console.WriteLine("saindo do sistema..."); System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
}
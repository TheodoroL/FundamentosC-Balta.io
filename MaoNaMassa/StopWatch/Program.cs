
class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo => 10s");
        Console.WriteLine("M = Minutos => 1m = 60s");
        Console.WriteLine("00 = Sair");
        Console.Write("Quanto tempo ? :");

        string data = Console.ReadLine().ToLower();
        Console.WriteLine(data);

        /*
            Subtring basicamente vai pegar a posição inicial e aonde vai até o final das caracteres vai pegar, 
            exemplo : 
            string teste = "Duck"; 
            Console.WritLine(teste.SubsString(teste-Length -1, 1)); // vai aparecer k

            para você pegar mais caracteres, você também diminuir mais o Length, exemplo:
            string teste = "Duck"; 
            Console.WritLine(teste.SubsString(teste-Length -2, 2)); // vai aparecer ck


               
        */

        char type = char.Parse(data.Substring(data.Length - 1, 1));
        Console.Write(type);
        int time = int.Parse(data.Substring(0, data.Length - 1));
        Console.WriteLine(time);
        switch (type)
        {
            case 's':
                Start(time);
                break;
            case 'm':
                Start(time * 60);
                break;
            case '0':
                Console.WriteLine("Saindo do programa");
                System.Environment.Exit(0);
                break;
            default:
                Console.WriteLine("opção invalida");
                break;
        }


    }
    static void Start(int time)
    {
        int currentTime = 0;
        while (currentTime != time)
        {
            Console.Clear();
            Console.WriteLine(currentTime);
            currentTime++;
            Thread.Sleep(100);
        }
        Console.Clear();
        Console.WriteLine("Finsh StopWatch");
        Thread.Sleep(2500);
        Menu();
    }



}
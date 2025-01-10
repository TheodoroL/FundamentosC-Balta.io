class Program
{
    public static void Main(string[] args)
    {
        for (var n = 0; n < 10; n++)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();
        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(i);

        }
        Console.WriteLine();

        for (var n = 0; n <= 10; n++)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n}->Par");
            }
            else
            {
                Console.WriteLine($"{n}->Impar");

            }
        }
    }
}
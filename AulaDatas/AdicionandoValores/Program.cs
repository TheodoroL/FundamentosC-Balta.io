class Program
{
    public static void Main(string[] args)
    {
        var data = DateTime.Now;
        Console.WriteLine(data); // nomral
        Console.WriteLine(data.AddDays(12)); // adiciona 12 dias
        Console.WriteLine(data.AddMonths(1)); // adiciona 1 mês
        Console.WriteLine(data.AddYears(1));// adiciona 1 ano

    }
}
class Program
{
    public static void Main(string[] args)
    {

        Console.Clear();
        var data = new DateTime(2021, 10, 12, 8, 22, 30);
        Console.WriteLine(data);
        Console.WriteLine(data.Year); // Ano
        Console.WriteLine(data.Month); // Mês
        Console.WriteLine(data.Day); // dia
        Console.WriteLine(data.Hour); // hora
        Console.WriteLine(data.Minute); // Minuto
        Console.WriteLine(data.Second); // segundo

        Console.WriteLine(data.DayOfWeek); // vai mostar o dia da semana
        Console.WriteLine(data.DayOfYear); // vai mostar o dia do ano 



    }
}
class Program
{
    public static void Main(string[] args)
    {

        Console.Clear();
        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);//00:00:00
        var timeSpanNanoSegundos = new TimeSpan(1);
        Console.WriteLine(timeSpanNanoSegundos);//00:00:00.0000001

        var timeSpanHoraMinutoSegundo = new TimeSpan(10, 30, 5);
        Console.WriteLine(timeSpanHoraMinutoSegundo);//10:30:05

        var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 10, 30, 5);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo);//3.10:30:05


        var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(3, 10, 30, 5, 100);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);//3.10:30:05.1000000

        Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundoMilissegundo);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
    }
}
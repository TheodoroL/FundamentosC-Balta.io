class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        var dataTime = DateTime.UtcNow;
        Console.WriteLine(dataTime);
        Console.WriteLine(dataTime.ToLocalTime());

        var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.WriteLine(timeZoneAustralia);

        var horasAustralia = TimeZoneInfo.ConvertTimeFromUtc(dataTime, timeZoneAustralia);

        Console.WriteLine($"Horas da australia : {horasAustralia}");


        var allTimezones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in allTimezones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataTime, timezone));
            Console.WriteLine("----------------------");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        var data = DateTime.Now;
        if (data.Date == DateTime.Now.Date)
        {
            Console.WriteLine("é igual");
        }
        Console.WriteLine(data);
    }
}
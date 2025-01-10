class Program
{
    public static void Main(string[] args)
    {
        //vai criar um hash de forma aleatória 
        Guid id = Guid.NewGuid();
        Console.WriteLine(id);
        Console.WriteLine(id.ToString().Substring(0, 8));

    }
}
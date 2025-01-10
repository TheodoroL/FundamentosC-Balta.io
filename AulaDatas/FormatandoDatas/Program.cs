class Program
{
    public static void Main(string[] args)
    {

        var data = DateTime.Now;
        /*
            dd : dia 
            M : mês 
            yyyy: ano 

            hh: hora
            mm : minutos
            ss: segundos 
        */
        string formatada = string.Format("{0:dd/MM/yyyy\nhh:mm:ss}", data);
        Console.WriteLine(formatada);
    }
}
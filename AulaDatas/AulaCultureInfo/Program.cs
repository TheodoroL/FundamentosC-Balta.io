using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        var br = new CultureInfo("pt-BR");
        var pt = new CultureInfo("pt-PT");
        var en = new CultureInfo("en-US");
        var atual = CultureInfo.CurrentCulture;
        var data = DateTime.Now;
        Console.WriteLine(data.ToString("D", en));  // inglês
        Console.WriteLine(data.ToString("D", pt));  // Português de Portugal
        Console.WriteLine(data.ToString("D", br));  // Portguês Br
        Console.WriteLine(data.ToString("D", atual));  // Pega o idioma atual da máquina 

    }
}
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        StringBuilder texto = new(); // O StringBulder tem com objetivo de ser usado quando o texto é longo e gerado de forma dinamicamente
        texto.Append("Estou testando esse texto");
        texto.Append("Pois isso é apenas um teste");
        texto.Append("Não sei nem que estou falando, mas estou testando isso :)");

        string value = texto.ToString();
        Console.WriteLine(value);

    }
}
class Program
{
    public static void Main(string[] args)
    {
        string texto = "Este texto é um teste";
        /* O StartsWith tem como objetivo de verificar o inicio da String, se tiver igual o valor que passou vai retornar True
        
            O StartsWith tem StringComparison para configurar do jeito que voc~e quer
        */

        Console.WriteLine(texto.StartsWith("Este")); // True
        Console.WriteLine(texto.StartsWith("este", StringComparison.CurrentCultureIgnoreCase));// True por causa do StringComparison.CurrentCultureIgnoreCase
        Console.WriteLine(texto.StartsWith("Texto"));// False
        Console.WriteLine(texto.StartsWith("texto"));//False

        Console.WriteLine("-----  EndsWith ---");
        // O EndsWith é quase a mesma coisa que StartsWith, porém invés ser o inicio da string, é o final
        Console.WriteLine(texto.EndsWith("teste"));//True
        Console.WriteLine(texto.EndsWith("Teste"));//false
        Console.WriteLine(texto.EndsWith("apenas"));//false



    }
}
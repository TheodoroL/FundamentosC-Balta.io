class Program
{
    public static void Main(string[] args)
    {
        string texto = "Esse texto é um teste";
        Console.WriteLine(texto.IndexOf('é')); //vai retornar a posição do caractere especifico
        Console.WriteLine(texto.LastIndexOf('s')); // vai retornar a ultima palavra que ele achou na string
    }
}
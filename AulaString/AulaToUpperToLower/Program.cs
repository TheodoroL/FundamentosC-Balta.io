


class Program
{
    public static void Main(string[] args)
    {
        string texto = "Esse texto é um teste";
        Console.WriteLine(texto.ToUpper()); // vai deixar tudo maiúsculo 
        Console.WriteLine(texto.ToLower()); // vai deixar tudo mainusculo 
        Console.WriteLine(texto.Insert(5, "Aqui")); // insere um valor na posição que você quer 

        Console.WriteLine(texto.Remove(5, 4));// Remove uma quantidade de caracteres na posição que você quer 
        Console.WriteLine(texto.Length); // Mostra o tamanho da string
    }
}
class Program
{
    public static void Main(string[] args)
    {
        //Determina se o objeto especificado é igual ao objeto atual.
        string texto = "Este texto é um teste";
        Console.WriteLine(texto.Equals("Este texto é um teste"));//True
        Console.WriteLine(texto.Equals("este texto é um teste"));//False 
        Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.CurrentCultureIgnoreCase));//True por causa do StringComparison

    }
}
class Program
{
    public static void Main(string[] args)
    {
        string texto = "Esse é um texto de teste";
        Console.WriteLine(texto.Replace("Esse", "Isso")); // troca a Palavra especifica por outra 
        Console.WriteLine(texto.Replace("e", "X")); // troca a Palavra especifica por outra 

        var divisao = texto.Split(" "); // divide o texto em partes em um array 

        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);

        string resultado = texto.Substring(10, 5); // vai pegar a palavra texto 
        Console.WriteLine(resultado);


        Console.WriteLine(texto.Trim()); // tira os espaços no inicio e no fim da string
    }

}
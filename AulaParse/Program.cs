class Program
{
    public static void Main(string[] args)
    {

        /* O Parse tem todo tipo primitivo
           objetivo dele é converter uma string para um tipo especifico, por exemplo:
        */
        int inteiro = int.Parse("100");

        Console.WriteLine($"valor:{inteiro} -> tipo :{inteiro.GetType()}");
    }
}
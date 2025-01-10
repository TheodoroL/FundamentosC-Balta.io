class Program
{
    public static void Main(string[] args)
    {
        int valor = 10;
        MeuMetodo(RetornarTexto());
        MeuMetodo(Fib(valor).ToString());
    }
    public static void MeuMetodo(string text)
    {
        Console.WriteLine(text);
    }
    static string RetornarTexto()
    {
        return "Olá mundo";
    }
    static int Fib(int n)
    {
        if (n == 0 | n == 1)
        {
            return n;
        }
        return Fib(n - 1) + Fib(n - 2);
    }

}
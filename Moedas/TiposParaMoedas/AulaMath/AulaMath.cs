namespace TiposParaMoedas;

public static class AulaMath
{

    public static void ArredondarValor(decimal valor)
    {
        Console.WriteLine(Math.Round(valor));
    }
    public static void ArredondarValorMais(decimal valor)
    {
        Console.WriteLine(Math.Ceiling(valor));

    }

    public static void ArredondarValorMenos(decimal valor)
    {
        Console.WriteLine(Math.Floor(valor));

    }
}
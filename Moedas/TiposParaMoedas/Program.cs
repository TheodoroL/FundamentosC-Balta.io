namespace TiposParaMoedas;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        decimal valor = 30.2m;
        // Console.WriteLine(valor);
        // FormatandoMoedas.TesteFormatacao(valor);
        // FormatandoMoedas.TodasFomatacao(valor);

        // Parte do Math

        AulaMath.ArredondarValor(valor);
        AulaMath.ArredondarValorMais(valor);
    }
}
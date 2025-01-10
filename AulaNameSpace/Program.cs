using AulaNameSpace.Calculos;

namespace AulaNameSpace;
class Program
{
    static void Main()
    {
        Calculo calculo = new(2, 3);
        Console.WriteLine(calculo);
        Console.WriteLine(calculo.Soma());
    }
}
class Program
{
    static void Main()
    {
        /*
            float : tem que colocar o F
            double
            decimal : tem que colocar o M
        
        ------------------------------------
        float : 32bits
        double : 64bits
        decimal: 128bits
        */

        float n = 2.0f;
        double n2 = 2.0;
        decimal n3 = 2.1m;
        Console.WriteLine($"float : {n}\ndouble:{n2}\ndecimal:{n3}");
    }
}
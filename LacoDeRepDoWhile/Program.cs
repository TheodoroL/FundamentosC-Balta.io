class Program
{
    public static void Main(string[] args)
    {
        int value = 0;
        //vai executar primeiro que está dentro do; se a condição for true, ele vai continuar a excutar.
        do
        {
            value++;
            Console.WriteLine(value);
        } while (value <= 5);
    }
}
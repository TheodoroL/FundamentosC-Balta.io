class Program
{
    public static void Main(string[] args)
    {
        //parte que tem uma copia
        int x = 10;
        int y = x;
        Console.WriteLine(x);//25
        Console.WriteLine(y);//25

        x = 33;

        Console.WriteLine(x);// 33
        Console.WriteLine(y);//25
        // não faz uma copia, mas sim uma referencia 
        string[] arr = new string[2];
        arr[0] = "Item 1";
        var arr2 = arr;

        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);

        arr[0] = "Item2";


        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);



    }
}
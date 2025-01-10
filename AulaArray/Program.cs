class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        var arr = new int[4];
        // var arrb = arr; // está apontando para o arr e n criando uma copia 
        var arrb = new int[4];
        arrb[0] = arr[0]; // 0
        arr[0] = 23;
        Console.WriteLine(arrb[0]);
    }

    public static void PercorrendoUmaArrayComForEach()
    {
        var myArray = new int[5] { 1, 2, 3, 4, 5 };
        foreach (var item in myArray)
        {
            Console.WriteLine(item);

        }
    }
    public static void PercorrendoUmaArray()
    {
        var myArray = new int[5] { 1, 2, 3, 4, 5 };
        for (int c = 0; c < myArray.Length; c++)
        {
            Console.WriteLine(myArray);
        }

    }

    public static void InicioDeArray()
    {
        // int[] meuArry2 =  new int[5];
        var meuArry = new int[5] { 1, 2, 3, 4, 5 };
        meuArry[0] = 12;
        Console.WriteLine(meuArry[0]);

        var arrayPeossa = new Pessoa[2];
        arrayPeossa[0] = new Pessoa("lucas", 19);
        arrayPeossa[1] = new Pessoa("daneo", 20);

        Console.WriteLine(arrayPeossa[0]);
        Console.WriteLine(arrayPeossa[1]);
    }
}
struct Pessoa(string nome, short idade)
{
    public string Nome = nome;
    public short Idade = idade;

    public override string ToString()
    {
        return $"nome:{Nome}\tidade:{Idade}";
    }
}
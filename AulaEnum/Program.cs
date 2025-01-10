// Serve para fornecer  um valor melhor visualização do código 

enum EproductType
{
    Product,
    Service
}

struct Product(int id, string name, double price, EproductType type)
{
    public int Id = id;
    public string Name = name;
    public double Price = price;
    public EproductType Type = type;

    public override string ToString()
    {
        return $"{Id}- name:{Name} | price:{Price} | type:{Type}";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        //mouse criado 
        var mouse = new Product(1, "Mouse gamer", 120, EproductType.Product);
        Console.WriteLine(mouse);
        //vai mostrar o valor inteiro do type do mouse
        Console.WriteLine((int)mouse.Type);// 0 
    }
}


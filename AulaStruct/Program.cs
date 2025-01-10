using System.Globalization;

struct Product
{
    public int id;
    public string name;
    public double price;

    public Product(int Id = 0, string Name = "", double Price = 0)
    {
        id = Id;
        name = Name;
        price = Price;
    }

    public double PriceInDolar()
    {
        return price / 6;
    }

}

class Program
{
    public static void Main(string[] args)
    {

        Product product = new()
        {
            id = 10,
            name = "Teclado",
            price = 120.40
        };


        Product product2 = new(10, "Mouse", 70);


        Console.WriteLine(product.PriceInDolar().ToString("0.00", CultureInfo.InvariantCulture));
        Console.WriteLine(product2.PriceInDolar().ToString("0.00"));
    }

}
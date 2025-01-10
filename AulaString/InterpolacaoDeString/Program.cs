class Program
{
    public static void Main(string[] args)
    {
        //jeito mais simples para fazer interpolação de string 
        double price = 10.2;
        string texto = "O preço do produto é : " + price + " apenas na promoção";
        //outro jeito de formatar o texto é usando o Format
        string texto2 = string.Format("O preço do produto é {0} apenas na promoção {1} ", price, true);
        // usando interpolação com sifrão($)
        string texto3 = $@"O preço do produto é {price} 
                apenas na promoção 
                {false}";/* @ defina que 
                
Identificadores Verbatim (@): Usado para utilizar palavras reservadas como identificadores.

Strings Verbatim (@"texto"): Cria strings literais onde os caracteres de escape não são interpretados.

Strings Interpoladas Verbatim (@$"texto"): Combina a interpolação de strings com a capacidade de criar strings literais.
                */
        Console.WriteLine(texto);
        Console.WriteLine(texto2);
        Console.WriteLine(texto3);

    }
}
namespace AulaExceptions;

public static class CustomExceptions
{
    public static void Aula()
    {
        try
        {
            Teste();

        }
        catch (MyException ex)
        {
            Console.WriteLine(ex.OqueOuve);
        }
    }

    private static void Teste()
    {
        Console.Write("digite um texto, se n escrever nd vai dar erro:");
        string texto = Console.ReadLine();
        if (string.IsNullOrEmpty(texto))
        {
            throw new MyException($"O erro foi causado no dia {DateTime.Now}");
        }

    }
}


class MyException : Exception
{
    public MyException(string texto)
    {
        OqueOuve = texto;
    }
    public string OqueOuve { get; set; }
}
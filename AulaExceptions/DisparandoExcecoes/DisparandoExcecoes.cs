namespace AulaExceptions;

public static class DisparandoExcecoes
{
    public static void Aula()
    {
        try
        {

            Cadastrar("");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new ArgumentNullException("O texto não pode ser vazio '-'");
        }

    }
}
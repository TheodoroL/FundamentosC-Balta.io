using System.Text;

namespace AulaExceptions;


public static class AulaTryCatch
{
    public static void Aula()
    {
        Console.Clear();
        var arrayPessoa = new Pessoa[2];
        try
        {
            for (int i = 0; i <= arrayPessoa.Length; i++)
            {
                Console.WriteLine(arrayPessoa[i]);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Não encontrei o indice do array");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ouve algum erro, se quiser ver os erros ver no logs.txt");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "logs.txt");
            using (var file = new StreamWriter(path, true))
            {
                file.Write($"{ex.Message}\n");
            }

        }
    }
}

struct Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
}
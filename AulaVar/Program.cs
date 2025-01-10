class EsseAquEumExemploDeUmaClasseGrande
{
    public int idade;
    public string nome;

    public EsseAquEumExemploDeUmaClasseGrande(int idadeP, string nomeP)
    {
        nome = nomeP;
        idade = idadeP;

    }
    public override string ToString()
    {
        return $"Nome:{nome}\nidade:{idade}";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        /* o var vai ser o tipo do primeiro valor atribuido, exemplo:
        
        idade vai ser do tipo int
        */
        var idade = 19;
        //mas de forma resumida, o var facilita Nós escrever menos linha de código, exemplo:
        var pessoa = new EsseAquEumExemploDeUmaClasseGrande(idade, "lucas");
        Console.WriteLine(pessoa);
        /*Se n coloca-se o var, ia ficar assim : 
        EsseAquEumExemploDeUmaClasseGrande pessoa = new EsseAquEumExemploDeUmaClasseGrande(idade, "lucas"); 
        */
    }
}
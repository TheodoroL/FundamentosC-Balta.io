class Program
{
    public static void Main(string[] args)
    {
        string texto = "testando";
        Console.WriteLine(texto.CompareTo("testando")); // vai retornar 0 para true e -1 para false
        /* O Contains tem com objetivo de pegar uma string e comparar ela se existe dentro de outra string
            O Contains tem um segundo parametro chamado StringComparison, que tem com objetivo 
            de fazer alguma configuração especifca. Exemplo: 
             texto.Contains("isso", StringComparison.CurrentCultureIgnoreCase ); 
            esse StringComparison.CurrentCultureIgnoreCas faz que o Contains valida a string ignorando se ele está maiusculo ou minusculo
        */
        Console.WriteLine(texto.Contains("isso", StringComparison.CurrentCultureIgnoreCase)); // ele retornar bool (nesse caso vai retornar True)

    }
}
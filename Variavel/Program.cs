class Program
{

    static void Main()
    {
        int idade = 19; // se você colocar nada, ele coloca zero 
        var nome = "TheodoroL"; // se eu não colocar algum valor nele, vai dar erro pois ele não tem um tipo definido
        string sobrenome = "Teste";

        Console.WriteLine($"nome: {nome} idade:{idade} sobrenome:{sobrenome}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        var datas = DateTime.Now;

        /*
            {0:t} : vai mostrar só a hora 
            {0:T} : vai mostrar a hora, minuots e segundos
     

            {0:d} : vai mostar o dia, mês e ano 
            {0:D} : vai mostar o dia, mês e ano de forma escrita 

            {0:f} : vai combinar 0:D e 0:t
            {0:g} : vai combinar 0:d e 0:t

            {0:r} : retorna isso daqui : Mon, 30 Dec 2024 13:01:35 GM
            {0:s}: utilizado bastante em formatado json e banco de dados:  2024-12-30T13:03:51
            {0:u} : Padrão Universal do DateTime 
            
        */
        string formatada = string.Format("{0:u}", datas);
        Console.WriteLine(formatada);
    }
}
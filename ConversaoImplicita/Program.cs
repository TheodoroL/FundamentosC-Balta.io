class Program
{
    public static void Main(string[] args)
    {
        float valor = 25.8f;
        int outro = 25;
        valor = outro; // operação implicita

        /*
        A conversão anterior ocorreu pois em  um número real pode receber um número inteiro
        Porém, ao contrario não aconteceria
            - Um número inteiro  não tem pontuação 
            - Logo ele não poderia receber um número real

        A conversão correta só será: 
            - Tipo de dado for compativel 
            - O tamanho de dado for compativel 

        */
    }
}
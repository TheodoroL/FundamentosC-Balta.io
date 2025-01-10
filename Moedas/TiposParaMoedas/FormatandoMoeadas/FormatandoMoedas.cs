using System.Globalization;

namespace TiposParaMoedas;




public static class FormatandoMoedas
{

    public static void TesteFormatacao(decimal valor)
    {
        /*
            G : Padrão de número, 
            C : Formata por padrão de moeda, 
            E04 : Quando o número é muito grande ele formata para esse jeito  "2.0250E+001", 
            F : Traz uma precisão maior do valor digitado, 
            N : Formata o número para moeda só que sem sem o simbolo 
            P : Formatada por porcentagem
        
        */
        Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("en-US")));
    }

    public static void TodasFomatacao(decimal valor)
    {
        List<string> lista = ["G", "C", "E04", "N", "P"];
        foreach (var l in lista)
        {
            Console.WriteLine(valor.ToString(l, CultureInfo.CreateSpecificCulture("en-UK")));
            for(short c= 0 ; c< lista.Count; c++) {
                Console.Write("-="); 
            }
            Console.WriteLine(); 
        }

    }

}
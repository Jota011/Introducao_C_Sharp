using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1º - boletim com media
//2º - 


namespace Aplicacao1
{
    internal class BASICO_STRINGS
    {
        static void Main(string[] args)
        {
            //String | Padrão né
            /*
            string nome = "Pedro";
            Console.WriteLine(nome);
            Console.WriteLine($"Oi {nome} and {nome}");
            Console.WriteLine("Oi " + nome + " dnv " + nome);
            */

            //Trim | Aqui ele tira os espaços extras da string (TrimStart = Do começo) e (TrimEnd = Do final da string)
            /*
            string nome2 = "*      Terik      *";
            Console.WriteLine($"{nome2}");

            string nomedois = nome2.TrimStart();
            Console.WriteLine(nomedois);

            nomedois = nome2.TrimEnd();
            Console.WriteLine(nomedois);

            nomedois = nome2.Trim();
            Console.WriteLine(nomedois);
            */

            //Substitua | Literalmente, aqui ele substitui uma palavra(retira)
            /*
            string sayHello = "OI";
            sayHello = sayHello.Replace("OI", "tEsTes");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper()); //Substitui tudo para MAIUSCULO
            Console.WriteLine(sayHello.ToLower()); //Substitui tudo para MINUSCULO
            */

            //Cadeia de caracteres de pesquisa | Pesquisa os caracteries por meio do Contains(" PALAVRA QUE ESTA PROCURANDO ")
            /*
            string songLyrics = "Voce diz adeus, eu digo ola";
            Console.WriteLine(songLyrics.Contains("adeus"));        //Retorna True
            Console.WriteLine(songLyrics.Contains("oloco meu"));    //Retorna Verdadeiro
            */

            //Desafio

            string desafio = "Oloco jovem, esse é o desafio??";
            Console.WriteLine(desafio.StartsWith("Oloco"));
            Console.WriteLine(desafio.StartsWith("jovem"));

            Console.WriteLine(desafio.EndsWith("desafio"));
            Console.WriteLine(desafio.EndsWith("esse é"));





            Console.ReadKey();
        }
    }
}

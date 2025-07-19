using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1º - boletim com media
//2º - 


namespace Aplicacao1
{
    internal class Program
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
            /*
            string desafio = "Oloco jovem, esse é o desafio??";
            Console.WriteLine(desafio.StartsWith("Oloco"));
            Console.WriteLine(desafio.StartsWith("jovem"));

            Console.WriteLine(desafio.EndsWith("desafio"));
            Console.WriteLine(desafio.EndsWith("esse é"));
            */

            Console.WriteLine("Digte o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine($"Adicione as notas do Aluno {nomeAluno}");
            double[] notas = new double[4];
            double soma = 0;
            


            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Digite a nota da prova {i}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                //soma += notas[i];
            }
            
            for(int i = 1; i < 4; i++)
            {
                soma += notas[i];
            }
            

            double mediaAluno = soma / 3;

            Console.WriteLine($"\nAluno: {nomeAluno}");
            Console.WriteLine($"\nMedia Final: {mediaAluno}");



            if (mediaAluno >= 7)
            {
                Console.WriteLine($"Aluno {nomeAluno} está Aprovado");
            }
            else if (mediaAluno >= 5)
            {
                Console.WriteLine($"Aluno {nomeAluno} está Exame");
                double notaExame = Convert.ToDouble(Console.ReadLine());

                // Procura o índice da menor nota
                int indiceMenor = 0;
                for (int i = 1; i < 4; i++)
                {
                    if (notas[i] < notas[indiceMenor])
                    {
                        indiceMenor = i; // Atualiza o índice da menor nota
                    }
                }

                Console.WriteLine($"A menor nota foi substituída pela nota do exame: {notaExame:F1}");

                // Substitui a menor nota pela nota do exame
                notas[indiceMenor] = notaExame;

                // Recalcula a média com a nova nota
                double novaSoma = 0;
                for (int i = 0; i < 4; i++)
                {
                    novaSoma += notas[i];
                }

                double novaMedia = novaSoma / 4; // Nova média após exame

                Console.WriteLine($"Nova média após substituição: {novaMedia:F1}");

                // Verifica a nova situação do aluno
                if (novaMedia >= 7)
                {
                    Console.WriteLine("Situação final: Aprovado após exame ✅");
                }
                else
                {
                    Console.WriteLine("Situação final: Reprovado após exame ❌");
                }
            }
            else
            {
                Console.WriteLine("Aluno {nomeAluno} está Reprovado");
            }
            Console.ReadKey();
        }
    }
}

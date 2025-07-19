using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Informar um numero sorteado de 0 a 10:
            Console.WriteLine("Numeros de 0 10 ira ser sorteado, escolha o seu numero");
            Console.WriteLine("(Lembre de que você deve digitar apenas numeros)");
            int cont = 0;
            //bool cont = false;

            //while (cont == true)       //exemplo
            while (cont < 3) //Ou pode trocar por uma variavel 'bool'. Mas ai fica infinito o jogo, Aqui fiz com 3 tentativas.
                        
            {
            //Estrutura para sortear um numero: 
            Random rdm = new Random();
            int nS = rdm.Next(11); //o numero que o 'Next' sorteará é 0(numero negativo não funciona) e o numero inteiro menor que o maximo expecificado(ex: Next(10) -> menor numero inteiro vai ser o 9)


            //Qual numero foi sorteado? (opnião do usuário)
            Console.WriteLine("Qual numero vai ser sorteado?");

                //Aqui vai ler a reposta do usuario e comparar com o do random
            string numeroTexto = Console.ReadLine();
            int numero = int.Parse(numeroTexto);


                if (numero == nS)
                {
                    Console.Clear();
                    Console.WriteLine($"Acertou(Cagado). Numero sorteado foi: {nS}");
                    cont = 3;
                    //cont = true;     //exemplo
                }
                else
                {
                    string textoAjuda = "Numero digitado é menor que o numero sorteado";
                    Console.Clear();
                    Console.WriteLine($"Essa foi por pouco. Numero sorteado foi: {nS}");
                    if (numero < nS)
                    {
                        Console.WriteLine(textoAjuda);
                    }
                    else
                    {
                        textoAjuda = textoAjuda.Replace("menor", "maior");
                        Console.WriteLine(textoAjuda);
                    }
                }
            cont++;
            }
        }
        
    }
}

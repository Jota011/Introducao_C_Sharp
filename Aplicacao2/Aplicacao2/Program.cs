using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            bool V_F = true;
            float n1 = 0.1f;
            int n2 = 1;
            char c1 = 'a';
            */

            if (Teste() && Teste2()) // '&' um sinal,faz confirmação para ambas as afirmações. '&&' é padrao, um dos dois tem que ser TRUE
            {
                Console.WriteLine("Oloko");
            }

            if (Teste() & Teste2()) // '&' um sinal,faz confirmação para ambas as afirmações. '&&' é padrao, um dos dois tem que ser TRUE
            {
                Console.WriteLine("Oloko");
            }

            if (Teste() || Teste2())
            {
                Console.WriteLine("Olokinho");
            }

            if (Teste() | Teste2())
            {
                Console.WriteLine("Olokinho");
            }

            Console.ReadKey();
        }
        //Tem que esta fora da Main
        static bool Teste()
        {
            return false;
        }
        static bool Teste2()
        {
            return false;
        }
    }
}

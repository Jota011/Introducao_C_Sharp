using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] itens = new string[3];
            int count = 0;
            string respostas;

            for (int i = 0; i < itens.Length; i++)
            {
                if (itens[i] == "")
                {
                    Console.WriteLine("Qual o item a ser adicionado?");
                    respostas = Console.ReadLine();
                    itens[i] = respostas;
                }
                
            }

            while (count < itens.Length)
            {
                Console.WriteLine(itens[count]);
                count++;
            }

            /*
            foreach(string item in itens)
            {
                Console.WriteLine(itens);
            }*/

            Console.ReadKey();
        }
        
    }
}

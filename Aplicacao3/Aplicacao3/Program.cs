using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qualquer coisa: ");
            string textoDigitado = Console.ReadLine();

            //OP1 - Parse : converte numeros da 'string' para 'int'(mas só numeros)
            //int numeroDigitado = int.Parse(textoDigitado);

            //OP2 - TryParse : depois da conversão, ele retorna uma variavel tipo 'bool'.
            /*int numeroDigitado;
            bool conersao = int.TryParse(textoDigitado, out numeroDigitado); */

            //OP3 - Correto
            bool valorConvertido;
            bool conversao = bool.TryParse(textoDigitado, out valorConvertido);


            if (conversao)
            {
                Console.WriteLine("Deu Certo!!" + valorConvertido);
            }
            else
            {
                Console.WriteLine("Num deu não");
            }

                Console.ReadKey();
        }
    }
}

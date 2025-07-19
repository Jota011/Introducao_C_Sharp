using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ForcaNenhumErro = new string[] {
                @"    ╔═══╗",
                @"        ║",
                @"        ║",
                @"        ║",
                @"        ║",
                @"        ║",
                @"════════╩══"
            };

            string[] ForcaUmErro = new string[] {
                @"    ╔═══╗",
                @"    o   ║",
                @"        ║",
                @"        ║",
                @"        ║",
                @"        ║",
                @"════════╩══"
            };

            string[] ForcaDoisErros = new string[] {
                @"    ╔═══╗",
                @"    o   ║",
                @"    |   ║",
                @"        ║",
                @"        ║",
                @"        ║",
                @"════════╩══"
            };

            string[] ForcaTresErros = new string[] {
                @"    ╔═══╗",
                @"    o   ║",
                @"   /|   ║",
                @"        ║",
                @"        ║",
                @"        ║",
                @"════════╩══"
            };

            string[] ForcaQuatroErros = new string[] {
                @"    ╔═══╗",
                @"    o   ║",
                @"   /|\  ║",
                @"        ║",
                @"        ║",
                @"        ║",
                @"════════╩══"
            };

            string[] ForcaCincoErros = new string[] {
                @"    ╔═══╗",
                @"    o   ║",
                @"   /|\  ║",
                @"   /    ║",
                @"        ║",
                @"        ║",
                @"════════╩══"
            };

            string[] ForcaSeisErros = new string[] {
                @"    ╔═══╗",
                @"   X_x  ║",
                @"   /|\  ║",
                @"   / \  ║",
                @"        ║",
                @"        ║",
                @"════════╩══"
            };



            //Jogo da Forca
            //1. Digite a primeira palavra
            //2. Apagar todas as informações da tela
            //3. Exibir a quantidade de letras da palavra digitada
            //4. Solicitar a escolha de uma letra

            //1.
            Console.Write("Escreva uma palavra: ");
            string palavraChave = Console.ReadLine();
            string[] letrasIdentificadas = new string [palavraChave.Length];
            bool jogo = true;
            int qtdErros = 0;
            int limite = 6;



            do { 
                //2.
                Console.Clear();

                string[] desenhoForca;

                switch (qtdErros)
                {
                    case 1:
                        desenhoForca = ForcaUmErro;
                        break;
                    case 2:
                        desenhoForca = ForcaDoisErros;
                        break;
                    case 3: 
                        desenhoForca = ForcaTresErros;
                        break;
                    case 4:
                        desenhoForca = ForcaQuatroErros;
                        break;
                    case 5:
                        desenhoForca = ForcaCincoErros;
                        break;
                    case 6:
                        desenhoForca = ForcaSeisErros;
                        break;
                    default:
                        desenhoForca = ForcaNenhumErro;
                        break;

                }

                //Aqui desenha a forca
                for (int numeroLinha = 0; numeroLinha < desenhoForca.Length; numeroLinha++)
                {
                    Console.WriteLine(desenhoForca[numeroLinha]);
                }

                if (qtdErros == limite)
                {
                    jogo = false;
                }

                //3.
                int tam = palavraChave.Length;
                Console.WriteLine($"A palavra tem {tam} caracteres");

                Console.Write("Resposta: ");
                for (int i = 0; i < letrasIdentificadas.Length; i++)
                {
                    string letraAtual = letrasIdentificadas[i];
                    if (letraAtual == null)
                    {
                        Console.Write("_");
                    }
                    else
                    {
                        Console.Write(letraAtual);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


                //4.
                Console.Write("Escolha uma letra: ");
                string letra = Console.ReadLine();
                bool encontrada = false;

                for (int i = 0; i < tam; i++)
                {
                    string letraAtual = palavraChave[i].ToString();
                    if (letraAtual == letra)
                    {
                        letrasIdentificadas[i] = letraAtual;
                        encontrada = true; 
                    }
                }

                if (encontrada)
                {
                    bool todasLetrasIndentificadas = true;
                    for (int i = 0; i < letrasIdentificadas.Length; i++)
                    {
                        string letraAtual = letrasIdentificadas[i];
                        if (letraAtual == null)
                        {
                            todasLetrasIndentificadas = false;
                        }
                    }

                    if (todasLetrasIndentificadas)
                    {
                        jogo = false;
                    }
                }
                else
                {
                    qtdErros++;
                    Console.WriteLine("A letra não faz parte da palavra");
                }
            } while (jogo);

            Console.WriteLine();
            Console.WriteLine($"A palavra era: {palavraChave}");

            Console.WriteLine("Fim");
            Console.ReadKey();

        }
    }
}

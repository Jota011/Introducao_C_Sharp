using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Adicionar> itens = new List<Adicionar> ();
            Adicionar add = new Adicionar(); // Instância da classe Adicionar 
            Editar ed = new Editar();     // Instância da classe Editar
            Excluir ex = new Excluir();   // Instância da classe Excluir
            int count = 1;
            //string respostas;
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1-Adicionar");
                Console.WriteLine("2-Editar");
                Console.WriteLine("3-Excluir");
                Console.WriteLine("4-Listar");
                Console.WriteLine("0-Sair");
                Console.Write("Escolha uma opção: ");
                string entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out op))
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
                    continue; // volta ao menu
                }
                Console.Clear();
                switch (op)
                {
                    //chamar uma classe
                    case 1:
                        Console.WriteLine("Adicionar");
                        add.id = count++;
                        Console.Write("Nome do Item: ");
                        add.nomeItem = Console.ReadLine();
                        Console.Write("Validade: ");
                        add.val = int.Parse(Console.ReadLine());
                        itens.Add(add);
                        //Adicionar um item
                        break;
                    case 2:
                        Console.Write("Editar");
                        ed.EditarItem(itens);
                        //Editar os valores
                        break;
                    case 3:
                        Console.Write("Excluir");
                        ex.ExcluirItem(itens);
                        //Excluit itens
                        break;
                    case 4:
                        Console.WriteLine("Listar");
                        if (itens.Count > 0)
                        {
                            for (int i = 0; i < itens.Count; i++)
                            {
                                Console.Write($"Id: {itens[i].id}\nNome: {itens[i].nomeItem}\nVal: {itens[i].val}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nada encontrado");
                        }
                        Console.ReadLine();
                        break;
                }
            } while (op != 0);
            Console.WriteLine("Encerrando...");
            Console.ReadKey();
            Environment.Exit(0);
        }
        
    }
}

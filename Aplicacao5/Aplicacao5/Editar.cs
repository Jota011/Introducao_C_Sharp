using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao5
{
    class Editar
    {
        public void EditarItem(List<Adicionar> itens)
        {
            Console.Write("Digite o id do item a editar: ");
            int id = int.Parse(Console.ReadLine());

            var item = itens.Find(x => x.id == id);

            if (item != null)
            {
                Console.Write("Novo nome: ");
                item.nomeItem = Console.ReadLine();
                Console.Write("Nova validade: ");
                item.val = int.Parse(Console.ReadLine());
                Console.WriteLine("Item editado com sucesso");
            }
            else
            {
                Console.WriteLine("Item nao encontrado");
            }
        }
        /*{
            public int cod;
            public string nomeNovo;
            public int valNova;
        }*/
    }
}

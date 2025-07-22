using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao5
{
    public class Excluir
    {
        public void ExcluirItem(List<Adicionar> itens)
        {
            Console.Write("Digite o id do item: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var item = itens.Find(x => x.id == id);

                if (item != null)
                {
                    itens.Remove(item);
                    Console.WriteLine("Item excluido com sucesso");
                }
                else
                {
                    Console.WriteLine("Item nao encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Id invalido.");
            }
        }
    }
}

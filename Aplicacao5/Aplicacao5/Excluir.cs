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
                    item.status = !item.status;
                    //itens.Remove(item);       //aqui não vai mais ser deletado, mas sim desativado
                    Console.WriteLine("Item desativado com sucesso");
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

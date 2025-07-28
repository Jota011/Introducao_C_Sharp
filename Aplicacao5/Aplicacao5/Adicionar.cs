using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao5
{
    public class Adicionar
    {
        public int id;          //Identificacao
        public string nomeItem; //Nome
        public int val;         //Validade
        public bool status;     //Status de ativo/inativo
        public int qtd_PC;      //Quantidade por Peça
        public float qtd_L;     //Quantidade por Litros (rever por embalagem)
    }

    public class Dividir
    {
        //Aqui vai ser selecionado se vai ser quantidade em Litros ou Peças
        public int qtd_PC;
        public int qtd_L;
    }
}

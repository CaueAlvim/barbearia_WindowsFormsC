using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Models.Utils
{
    public class ItensLista
    {
        public ItensLista()
        {
            PRP_Requisicao = new RetornoRequisicao();
            PRP_DadosLista = new List<ItemLista>();
        }
        public RetornoRequisicao PRP_Requisicao { get; set; }
        public List<ItemLista> PRP_DadosLista { get; set; }

    }

    public class ItemLista
    {
        public string PRP_Chave { get; set; }
        public string PRP_Valor { get; set; }
    }
}

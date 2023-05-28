using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Entity
{
    [Table("barbeiro_agendamento")]
    public class barbeiro_agendamento
    {
        [Key]
        public int BARBEIRO_bar_id { get; set; }
        public string AGENDAMENTO_agn_cli_nome { get; set; }
        public string AGENDAMENTO_agn_bar_nome { get; set; }
        public string AGENDAMENTO_agn_ser_tiposervico { get; set; }
        public DateTime AGENDAMENTO_agn_datahora { get; set; }
        public int AGENDAMENTO_agn_id { get; set; }

    }
}

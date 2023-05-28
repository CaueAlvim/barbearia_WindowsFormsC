using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Entity
{
    [Table("agendamento")]
    public class agendamento
    {
        [Key]
        public int agn_id { get; set; }
        public string agn_cli_nome { get; set; }
        public string agn_bar_nome { get; set; }
        public string agn_ser_tiposervico { get; set; }
        public DateTime agn_datahora { get; set; }

    }
}

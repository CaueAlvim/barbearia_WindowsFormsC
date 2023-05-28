using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Entity
{
    [Table("barbeiro_cliente")]
    public class barbeiro_cliente
    {
        [Key]
        public int BARBEIRO_bar_id { get; set; }
        public int CLIENTE_cli_id { get; set; }
    }
}

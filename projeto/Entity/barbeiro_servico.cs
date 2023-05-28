using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Entity
{
    [Table("barbeiro_servico")]
    public class barbeiro_servico
    {
        [Key]
        public int BARBEIRO_bar_id { get; set; }
        public int SERVICO_ser_id { get; set; }
    }
}

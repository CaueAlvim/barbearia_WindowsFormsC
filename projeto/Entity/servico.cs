using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Entity
{
    [Table("servico")]
    public class servico
    {
        [Key]
        public int ser_id { get; set; }
        public string ser_tiposervico { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Entity
{
    [Table("barbeiro")]
    public class barbeiro
    {
        [Key]
        public int bar_id { get; set; }
        public string bar_nome { get; set; }
        public string bar_telefone { get; set; }
        public string bar_email { get; set; }
        public string bar_cpf { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Entity
{
    [Table("cliente")]
    public class cliente
    {
        [Key]
        public int cli_id { get; set; }
        public string cli_nome { get; set; }
        public string cli_telefone { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_barbearia.Models;
namespace projeto_barbearia.Test.Fixtures
{
    
    public class TestFixture
    {
        public Models.Base.Cliente PRP_Cliente;

        public TestFixture()
        {
            PRP_Cliente = new Models.Base.Cliente();
        }
    }
}

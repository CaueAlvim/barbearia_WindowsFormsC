namespace projeto_barbearia.Test
{
    [Collection("Testes")]
    public class BaseTeste_Cliente
    {
        private Fixtures.TestFixture fixture;
        public BaseTeste_Cliente(Fixtures.TestFixture testFixture)
        {
            fixture = testFixture;
        }
        [Fact]
        public void MTD_ListarClientes()
        {
            Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();
            var retorno = fixture.PRP_Cliente.MTD_ListarClientes(requisicao);

            Assert.True(requisicao.PRP_Sucesso);
        }

        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(2, true)]
        public void MTD_ObterCliente(int ID, bool valorEsperado)
        {
            Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();
            var retorno = fixture.PRP_Cliente.MTD_ObterCliente(requisicao, ID);
            if (requisicao.PRP_Sucesso)
                Console.WriteLine($"ID:{ID} >> Nome: {retorno.cli_nome}");
            else
            {
                Console.WriteLine(requisicao.PRP_Mensagem);
            }

            Assert.Equal(valorEsperado, requisicao.PRP_Sucesso);
        }


        [Theory]
        [InlineData("Cliente 01", "(11) 91234-5678")]
        [InlineData("Cliente 02", "(12) 91234-5678")]
        [InlineData("Cliente 03", "(13) 91234-5678")]
        public void MTD_CadastrarCliente(string Nome, string Telefone)
        {
            //Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();
            var cliente = new Entity.cliente { cli_nome = $"{Nome}_{DateTime.Now:dd/MM/yyyy HH:mm:ss}", cli_telefone = Telefone };
            var retorno = fixture.PRP_Cliente.MTD_CadastrarCliente(cliente);
            if (retorno.PRP_Sucesso)
                Console.WriteLine($"ID:{cliente.cli_id} >> Nome: {cliente.cli_nome}");
            else
            {
                Console.WriteLine(retorno.PRP_Mensagem);
            }
            Assert.True(retorno.PRP_Sucesso);
        }

        [Fact]
        public void MTD_AtualizaCliente()
        {
            Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();
            var cliente = fixture.PRP_Cliente.MTD_ObterCliente(requisicao, 1);
            if (requisicao.PRP_Sucesso)
            {
                cliente.cli_nome = $"Alterado{DateTime.Now}";
            }
                var retorno = fixture.PRP_Cliente.MTD_AtualizaCliente(cliente);

            Assert.True(requisicao.PRP_Sucesso);
            Assert.True(retorno.PRP_Sucesso);


        }

        [Fact]
        public void MTD_ExcluirCliente()
        {
            Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();
            var cliente = fixture.PRP_Cliente.MTD_ObterCliente(requisicao, 1);
          
            var retorno = fixture.PRP_Cliente.MTD_ExcluirCliente(cliente);

            Assert.True(requisicao.PRP_Sucesso);
            Assert.True(retorno.PRP_Sucesso);


        }
    }
}
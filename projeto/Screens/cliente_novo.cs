using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_barbearia.Entity;
using projeto_barbearia.Models.Base;

namespace projeto_barbearia
{
    public partial class cliente_novo : Form
    {
        public cliente_novo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void button1_entrar_Click(object sender, EventArgs e)
        {
            // Aqui você pode obter os dados do novo cliente a partir dos campos do formulário
            string nome = textBox1.Text;
            string telefone = textBox2.Text;

            // Criar uma instância do cliente
            Cliente cliente = new Cliente();

            // Chamar o método MTD_CadastrarCliente
            Models.Utils.RetornoRequisicao retorno = cliente.MTD_CadastrarCliente(new Entity.cliente() { cli_nome = nome, cli_telefone = telefone });

            // Verificar o resultado da operação
            if (retorno.PRP_Sucesso)
            {
                // Cliente cadastrado com sucesso
                MessageBox.Show(retorno.PRP_Mensagem);
            }
            else
            {
                // Ocorreu um erro ao cadastrar o cliente
                MessageBox.Show(retorno.PRP_Mensagem);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Criar um objeto RetornoRequisicao
            Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();

            // Criar uma instância da classe ClasseCliente
            Cliente classeCliente = new Cliente();

            // Chamar o método MTD_ListarClientes para obter a lista de clientes
            List<Entity.cliente> clientes = classeCliente.MTD_ListarClientes(requisicao);

            // Verificar se a requisição foi bem-sucedida
            if (requisicao.PRP_Sucesso)
            {
                // Preencher a ListBox com os clientes
                foreach (var cliente in clientes)
                {
                    listBox1.Items.Add(string.Format("{0} - {1}", cliente.cli_id, cliente.cli_nome));
                }

                // Exibir a mensagem de sucesso
                MessageBox.Show(requisicao.PRP_Mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Exibir a mensagem de erro
                MessageBox.Show(requisicao.PRP_Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_excluir_Click(object sender, EventArgs e)
        {
            // Ler o valor da TextBox
            string clienteIdTexto = textBox3.Text;

            // Verificar se o valor é válido
            if (!int.TryParse(clienteIdTexto, out int clienteId))
            {
                MessageBox.Show("O ID do cliente é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar uma instância do formulário cliente_exclui
            Cliente form = new Cliente();

            // Criar uma instância do objeto cliente e definir o ID
            Entity.cliente ClienteAutualizado = new Entity.cliente();
            ClienteAutualizado.cli_id = clienteId;

            // Chamar o método MTD_ExcluirCliente
            Models.Utils.RetornoRequisicao retorno = form.MTD_ExcluirCliente(ClienteAutualizado);

            // Exibir mensagem de sucesso ou erro com base no retorno
            if (retorno.PRP_Sucesso)
            {
                MessageBox.Show(retorno.PRP_Mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(retorno.PRP_Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

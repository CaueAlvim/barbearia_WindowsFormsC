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

namespace projeto_barbearia.Screens
{
    public partial class barbeiro_novo : Form
    {
        public barbeiro_novo()
        {
            InitializeComponent();
        }

        private void button1_entrar_Click(object sender, EventArgs e)
        {
            // Aqui você pode obter os dados do novo barbeiro a partir dos campos do formulário
            string nome = textBox1.Text;
            string telefone = textBox2.Text;
            string email = textBox3.Text;
            string cpf = textBox4.Text;

            // Criar uma instância do barbeiro
            Barbeiro barbeiro = new Barbeiro();

            // Chamar o método MTD_CadastrarBarbeiro
            Models.Utils.RetornoRequisicao retorno = barbeiro.MTD_CadastrarBarbeiro(new Entity.barbeiro() { bar_nome = nome, bar_telefone = telefone, bar_email = email, bar_cpf = cpf });

            // Verificar o resultado da operação
            if (retorno.PRP_Sucesso)
            {
                // Barbeiro cadastrado com sucesso
                MessageBox.Show(retorno.PRP_Mensagem);
            }
            else
            {
                // Ocorreu um erro ao cadastrar o barbeiro
                MessageBox.Show(retorno.PRP_Mensagem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Criar um objeto RetornoRequisicao
            Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();

            // Criar uma instância da classe ClasseBarbeiro
            Barbeiro classeBarbeiro = new Barbeiro();

            // Chamar o método MTD_ListarBarbeiros para obter a lista de clientes
            List<Entity.barbeiro> barbeiros = classeBarbeiro.MTD_ListarBarbeiros(requisicao);

            // Verificar se a requisição foi bem-sucedida
            if (requisicao.PRP_Sucesso)
            {
                // Preencher a ListBox com os clientes
                foreach (var barbeiro in barbeiros)
                {
                    listBox1.Items.Add(string.Format("{0} - {1} - {2} - {3} - {4}", barbeiro.bar_id, barbeiro.bar_nome, barbeiro.bar_telefone, barbeiro.bar_email, barbeiro.bar_cpf));
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
            string barbeiroIdTexto = textBox5.Text;

            // Verificar se o valor é válido
            if (!int.TryParse(barbeiroIdTexto, out int barbeiroId))
            {
                MessageBox.Show("O ID do barbeiro é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar uma instância do formulário barbeiro_exclui
            Barbeiro form = new Barbeiro();

            // Criar uma instância do objeto barbeiro e definir o ID
            Entity.barbeiro BarbeiroAutualizado = new Entity.barbeiro();
            BarbeiroAutualizado.bar_id = barbeiroId;

            // Chamar o método MTD_ExcluirBarbeiro
            Models.Utils.RetornoRequisicao retorno = form.MTD_ExcluirBarbeiro(BarbeiroAutualizado);

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

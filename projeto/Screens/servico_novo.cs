using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using projeto_barbearia.Entity;
using projeto_barbearia.Models.Base;

namespace projeto_barbearia.Screens
{
    public partial class servico_novo : Form
    {
        public servico_novo()
        {
            InitializeComponent();
        }

        private void button1_entrar_Click(object sender, EventArgs e)
        {
            // Aqui você pode obter os dados do novo servico a partir dos campos do formulário
            string tiposervico = textBox1.Text;

            // Criar uma instância do servico
            Servico servico = new Servico();

            // Chamar o método MTD_CadastrarServico
            Models.Utils.RetornoRequisicao retorno = servico.MTD_CadastrarServico(new Entity.servico() { ser_tiposervico = tiposervico });

            // Verificar o resultado da operação
            if (retorno.PRP_Sucesso)
            {
                // Servico cadastrado com sucesso
                MessageBox.Show(retorno.PRP_Mensagem);
            }
            else
            {
                // Ocorreu um erro ao cadastrar o servico
                MessageBox.Show(retorno.PRP_Mensagem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Criar um objeto RetornoRequisicao
            Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();

            // Criar uma instância da classe ClasseServico
            Servico classeServico = new Servico();

            // Chamar o método MTD_ListarServicos para obter a lista de servico
            List<Entity.servico> servicos = classeServico.MTD_ListarServicos(requisicao);

            // Verificar se a requisição foi bem-sucedida
            if (requisicao.PRP_Sucesso)
            {
                // Preencher a ListBox com os servicos
                foreach (var servico in servicos)
                {
                    listBox1.Items.Add(string.Format("{0} - {1}", servico.ser_id, servico.ser_tiposervico));
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
            string servicoIdTexto = textBox2.Text;

            // Verificar se o valor é válido
            if (!int.TryParse(servicoIdTexto, out int servicoId))
            {
                MessageBox.Show("O ID do servico é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar uma instância do formulário servico_exclui
            Servico form = new Servico();

            // Criar uma instância do objeto servico e definir o ID
            Entity.servico ServicoAtualizado = new Entity.servico();
            ServicoAtualizado.ser_id = servicoId;

            // Chamar o método MTD_ExcluirServico
            Models.Utils.RetornoRequisicao retorno = form.MTD_ExcluirServico(ServicoAtualizado);

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

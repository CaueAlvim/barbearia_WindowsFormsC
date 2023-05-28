using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeto_barbearia.Screens
{
    public partial class agendamento_novo : Form
    {
        public agendamento_novo()
        {
            InitializeComponent();
        }


        private void button1_entrar_Click(object sender, EventArgs e)
        {
            // Recuperar os valores selecionados nas ComboBoxes
            Entity.cliente clienteSelecionado = comboBox1.SelectedItem as Entity.cliente;
            Entity.barbeiro barbeiroSelecionado = comboBox2.SelectedItem as Entity.barbeiro;
            Entity.servico servicoSelecionado = comboBox3.SelectedItem as Entity.servico;

            // Verificar se todos os valores foram selecionados corretamente
            if (clienteSelecionado == null || barbeiroSelecionado == null || servicoSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar uma nova instância do objeto Entity.agendamento e atribuir os valores selecionados
            Entity.agendamento novoAgendamento = new Entity.agendamento();
            novoAgendamento.agn_cli_nome = clienteSelecionado.cli_nome;
            novoAgendamento.agn_bar_nome = barbeiroSelecionado.bar_nome;
            novoAgendamento.agn_ser_tiposervico = servicoSelecionado.ser_tiposervico;
            novoAgendamento.agn_datahora = dateTimePicker1.Value;

            // Criar uma instância da classe que contém o método MTD_CadastrarAgendamentos
            Agendamento classeAgendamento = new Agendamento();

            // Chamar o método MTD_CadastrarAgendamentos para cadastrar o agendamento
            Models.Utils.RetornoRequisicao requisicao = classeAgendamento.MTD_CadastrarAgendamentos(novoAgendamento);

            // Verificar o resultado da requisição
            if (requisicao.PRP_Sucesso)
            {
                // Cadastro realizado com sucesso
                MessageBox.Show(requisicao.PRP_Mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Ocorreu um erro ao cadastrar o agendamento
                MessageBox.Show(requisicao.PRP_Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agendamento_novo_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.ShowUpDown = true;

            // Criar um objeto RetornoRequisicao
            Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();

            // Criar uma instância das classes Cliente, Barbeiro e Servico
            Cliente classeCliente = new Cliente();
            Barbeiro classeBarbeiro = new Barbeiro();
            Servico classeServico = new Servico();

            // Chamar o método MTD_ListarClientes para obter a lista de clientes
            List<Entity.cliente> clientes = classeCliente.MTD_ListarClientes(requisicao);
            List<Entity.barbeiro> barbeiros = classeBarbeiro.MTD_ListarBarbeiros(requisicao);
            List<Entity.servico> servicos = classeServico.MTD_ListarServicos(requisicao);

            // Verificar se a requisição foi bem-sucedida
            if (requisicao.PRP_Sucesso)
            {
                // Preencher a ComboBox com os clientes
                comboBox1.DataSource = clientes;
                comboBox1.DisplayMember = "cli_nome";

                // Preencher a ComboBox com os barbeiros
                comboBox2.DataSource = barbeiros;
                comboBox2.DisplayMember = "bar_nome";

                // Preencher a ComboBox com os serviços
                comboBox3.DataSource = servicos;
                comboBox3.DisplayMember = "ser_tiposervico";
            }
            else
            {
                // Exibir a mensagem de erro
                MessageBox.Show(requisicao.PRP_Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Criar um objeto RetornoRequisicao
            Models.Utils.RetornoRequisicao requisicao = new Models.Utils.RetornoRequisicao();

            // Criar uma instância da classe ClasseBarbeiro
            Agendamento classeAgendamento = new Agendamento();

            // Chamar o método MTD_ListarBarbeiros para obter a lista de clientes
            List<Entity.agendamento> agendamentos = classeAgendamento.MTD_ListarAgendamentos(requisicao);

            // Verificar se a requisição foi bem-sucedida
            if (requisicao.PRP_Sucesso)
            {
                // Preencher a ListBox com os clientes
                foreach (var agendamento in agendamentos)
                {
                    listBox1.Items.Add(string.Format("{0} - {1} - {2} - {3} - {4}", agendamento.agn_id, agendamento.agn_cli_nome, agendamento.agn_bar_nome, agendamento.agn_ser_tiposervico, agendamento.agn_datahora));
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
            string agendamentoIdTexto = textBox5.Text;

            // Verificar se o valor é válido
            if (!int.TryParse(agendamentoIdTexto, out int agendamentoId))
            {
                MessageBox.Show("O ID do barbeiro é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar uma instância do formulário barbeiro_exclui
            Agendamento form = new Agendamento();

            // Criar uma instância do objeto barbeiro e definir o ID
            Entity.agendamento AgendamentoAtualizado = new Entity.agendamento();
            AgendamentoAtualizado.agn_id = agendamentoId;

            // Chamar o método MTD_ExcluirBarbeiro
            Models.Utils.RetornoRequisicao retorno = form.MTD_ExcluirAgendamento(AgendamentoAtualizado);

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

        private void button2_Click(object sender, EventArgs e)
        {

            // Verificar se uma linha foi selecionada na ListBox
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma linha para atualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Entity.cliente clienteSelecionado = comboBox1.SelectedItem as Entity.cliente;
            Entity.barbeiro barbeiroSelecionado = comboBox2.SelectedItem as Entity.barbeiro;
            Entity.servico servicoSelecionado = comboBox3.SelectedItem as Entity.servico;

            string selectedContent = listBox1.SelectedItem.ToString();

            // Fazer o parse da string para extrair as informações
            string[] parts = selectedContent.Split(" - ");

            int agendamentoId;
            int.TryParse(parts[0].Trim(), out agendamentoId);

            string clienteNome = parts[1].Trim();
            string barbeiroNome = parts[2].Trim();
            string servicoTipo = parts[3].Trim();

            DateTime dataHora;
            DateTime.TryParse(parts[4].Trim(), out dataHora);

            Entity.agendamento agendamentoSelecionado = new Entity.agendamento();
            agendamentoSelecionado.agn_id = agendamentoId;
            agendamentoSelecionado.agn_cli_nome = clienteSelecionado.cli_nome;
            agendamentoSelecionado.agn_bar_nome = barbeiroSelecionado.bar_nome;
            agendamentoSelecionado.agn_ser_tiposervico = servicoSelecionado.ser_tiposervico;
            agendamentoSelecionado.agn_datahora = dateTimePicker1.Value;

            // Criar uma instância da classe que contém o método MTD_AtualizaAgendamento
            Agendamento classeAgendamento = new Agendamento();

            // Chamar o método MTD_AtualizaAgendamento para atualizar o agendamento
            Models.Utils.RetornoRequisicao requisicao = classeAgendamento.MTD_AtualizaAgendamento(agendamentoSelecionado);

            // Verificar o resultado da requisição
            if (requisicao.PRP_Sucesso)
            {
                // Atualização realizada com sucesso
                MessageBox.Show(requisicao.PRP_Mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Ocorreu um erro ao atualizar o agendamento
                MessageBox.Show(requisicao.PRP_Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
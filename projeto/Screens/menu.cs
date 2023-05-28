using projeto_barbearia.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_barbearia
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_nova_Click(object sender, EventArgs e)
        {
            cliente_novo novocliente = new cliente_novo();
            novocliente.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            barbeiro_novo novobarbeiro = new barbeiro_novo();
            novobarbeiro.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            servico_novo novoservico = new servico_novo();
            novoservico.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agendamento_novo novoagendamento = new agendamento_novo();
            novoagendamento.Show();
        }
    }
}

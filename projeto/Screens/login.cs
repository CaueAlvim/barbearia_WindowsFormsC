using MySql.Data.MySqlClient;
namespace projeto_barbearia
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_entrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=barbearia;uid=root;pwd=");
            string selectAdmin = "SELECT  adm_senha, adm_usuario FROM administrador WHERE adm_usuario = @adm_usuario AND adm_senha = @adm_senha";
            MySqlCommand comando = new MySqlCommand(selectAdmin, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@adm_usuario", textBox1.Text);
            comando.Parameters.AddWithValue("@adm_senha", textBox2.Text);
            MySqlDataReader dr = comando.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Conectado");
                menu m1 = new menu();
                m1.Show();
            }
            else
            {
                MessageBox.Show("Registro não encontrado");
            }
        }
    }
}
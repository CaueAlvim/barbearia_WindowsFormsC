using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Models.Telas
{
    public class Login
    {
        private string _username;
        private string _password;
        public string PRP_Nome { get; }
        public string PRP_Senha { get; }
        public Login(string login,string senha)
        {
            _username = login;
            _password = senha;  
        }



       public Utils.RetornoRequisicao MTD_Autenticado()
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                requisicao.PRP_Mensagem = "Usuário autenticado com sucesso";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {

                
            }
            return requisicao;
        }
    }
}

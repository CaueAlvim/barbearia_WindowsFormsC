using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Models.Base
{
    public class Cliente
    {
        private Entity.AppDbContext _appDbContext;
        public Cliente()
        {
            _appDbContext = new Entity.AppDbContext();
        }

        public List<Entity.cliente> MTD_ListarClientes(Utils.RetornoRequisicao requisicao)
        {
            List<Entity.cliente> clientes = new List<Entity.cliente>();
            try
            {
                clientes = _appDbContext.Clientes.ToList();
                requisicao.PRP_Mensagem = $"Foram localizados {clientes.Count} clientes";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = $"Erro ao listar os usuários";
                requisicao.PRP_Sucesso = false;
            }

            return clientes;
        }
        /// <summary>
        /// Obtem um cliente da base de dados
        /// </summary>
        /// <param name="requisicao">Status da requisção</param>
        /// <param name="idCliente">Chave primaria da tabela cliente</param>
        /// <returns></returns>
        /*public Entity.cliente MTD_ObterCliente(Utils.RetornoRequisicao requisicao, int idCliente)
        {
            Entity.cliente clientes = null;
            try
            {
                clientes = _appDbContext.Clientes.FirstOrDefault(x=> x.cli_id.Equals(idCliente));
                if(clientes == null )
                {
                    requisicao.PRP_Mensagem = $"Cliente não localizado.";
                    requisicao.PRP_Sucesso = false;
                }
                else
                {
                    requisicao.PRP_Mensagem = $"Cliente localizado com sucesso.";
                    requisicao.PRP_Sucesso = true;
                }
             

            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = $"Erro ao listar os usuários";
                requisicao.PRP_Sucesso = false;

            }
            return clientes;
        }*/
        /// <summary>
        /// realiza o cadastro de um novo cliente
        /// </summary>
        /// <param name="novoCliente"></param>
        /// <returns></returns>
        public Utils.RetornoRequisicao MTD_CadastrarCliente(Entity.cliente novoCliente)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Clientes.Add(novoCliente);
                _appDbContext.SaveChanges();
                requisicao.PRP_Sucesso =true;
                requisicao.PRP_Mensagem = $"Novo cliente cadastrado com sucesso. ID {novoCliente.cli_id}";
            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = "Erro ao cadastrar novo cliente";
                requisicao.PRP_Sucesso=false;
            }

            return requisicao;
        }

        public Utils.RetornoRequisicao MTD_AtualizaCliente(Entity.cliente ClienteAutualizado)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Update(ClienteAutualizado);
                _appDbContext.SaveChanges();
                requisicao.PRP_Mensagem = "Cliente atualizado com sucesso";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {

                requisicao.PRP_Mensagem = "Erro ao atualizar o cliente";
                requisicao.PRP_Sucesso = false;
            }
            return requisicao;
        }

        public Utils.RetornoRequisicao MTD_ExcluirCliente(Entity.cliente ClienteAutualizado)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Remove(ClienteAutualizado);
                _appDbContext.SaveChanges();
                requisicao.PRP_Mensagem = "Cliente excluido com sucesso";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {

                requisicao.PRP_Mensagem = "Erro ao excluido o cliente";
                requisicao.PRP_Sucesso = false;
            }
            return requisicao;
        }

    }


}

using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Models.Base
{
    public class Agendamento
    {
        private Entity.AppDbContext _appDbContext;
        public Agendamento()
        {
            _appDbContext = new Entity.AppDbContext();
        }

        public List<Entity.agendamento> MTD_ListarAgendamentos(Utils.RetornoRequisicao requisicao)
        {
            List<Entity.agendamento> agendamentos = new List<Entity.agendamento>();
            try
            {
                agendamentos = _appDbContext.Agendamentos.ToList();
                requisicao.PRP_Mensagem = $"Foram localizados {agendamentos.Count} agendamentos";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = $"Erro ao listar os agendamentos";
                requisicao.PRP_Sucesso = false;
            }

            return agendamentos;
        }

        public Utils.RetornoRequisicao MTD_CadastrarAgendamentos(Entity.agendamento novoAgendamento)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Agendamentos.Add(novoAgendamento);
                _appDbContext.SaveChanges();
                requisicao.PRP_Sucesso = true;
                requisicao.PRP_Mensagem = $"Novo cliente cadastrado com sucesso. ID {novoAgendamento.agn_id}";
            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = "Erro ao cadastrar novo agendamento";
                requisicao.PRP_Sucesso = false;
            }

            return requisicao;
        }

        public Utils.RetornoRequisicao MTD_AtualizaAgendamento(Entity.agendamento AgendamentoAutualizado)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Update(AgendamentoAutualizado);
                _appDbContext.SaveChanges();
                requisicao.PRP_Mensagem = "Agendamento atualizado com sucesso";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {

                requisicao.PRP_Mensagem = "Erro ao atualizar o agendamento";
                requisicao.PRP_Sucesso = false;
            }
            return requisicao;
        }

        public Utils.RetornoRequisicao MTD_ExcluirAgendamento(Entity.agendamento AgendamentoAutualizado)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Remove(AgendamentoAutualizado);
                _appDbContext.SaveChanges();
                requisicao.PRP_Mensagem = "Agendamento excluido com sucesso";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {

                requisicao.PRP_Mensagem = "Erro ao excluir o agendamento";
                requisicao.PRP_Sucesso = false;
            }
            return requisicao;
        }

    }


}

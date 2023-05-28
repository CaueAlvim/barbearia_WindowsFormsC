using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Models.Base
{
    public class Servico
    {
        private Entity.AppDbContext _appDbContext;
        public Servico()
        {
            _appDbContext = new Entity.AppDbContext();
        }

        public List<Entity.servico> MTD_ListarServicos(Utils.RetornoRequisicao requisicao)
        {
            List<Entity.servico> servicos = new List<Entity.servico>();
            try
            {
                servicos = _appDbContext.Servicos.ToList();
                requisicao.PRP_Mensagem = $"Foram localizados {servicos.Count} serviços";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = $"Erro ao listar os serviços";
                requisicao.PRP_Sucesso = false;
            }

            return servicos;
        }
        public Utils.RetornoRequisicao MTD_CadastrarServico(Entity.servico novoServico)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Servicos.Add(novoServico);
                _appDbContext.SaveChanges();
                requisicao.PRP_Sucesso = true;
                requisicao.PRP_Mensagem = $"Novo serviço cadastrado com sucesso. ID {novoServico.ser_id}";
            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = "Erro ao cadastrar novo serviço";
                requisicao.PRP_Sucesso = false;
            }

            return requisicao;
        }

        public Utils.RetornoRequisicao MTD_ExcluirServico(Entity.servico ServicoAtualizado)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Remove(ServicoAtualizado);
                _appDbContext.SaveChanges();
                requisicao.PRP_Mensagem = "Serviço excluido com sucesso";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = "Erro ao excluir o Serviço";
                requisicao.PRP_Sucesso = false;
            }
            return requisicao;
        }

    }


}

using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Models.Base
{
    public class Barbeiro
    {
        private Entity.AppDbContext _appDbContext;
        public Barbeiro()
        {
            _appDbContext = new Entity.AppDbContext();
        }

        public List<Entity.barbeiro> MTD_ListarBarbeiros(Utils.RetornoRequisicao requisicao)
        {
            List<Entity.barbeiro> barbeiros = new List<Entity.barbeiro>();
            try
            {
                barbeiros = _appDbContext.Barbeiros.ToList();
                requisicao.PRP_Mensagem = $"Foram localizados {barbeiros.Count} barbeiros";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = $"Erro ao listar os barbeiros";
                requisicao.PRP_Sucesso = false;
            }

            return barbeiros;
        }
        public Utils.RetornoRequisicao MTD_CadastrarBarbeiro(Entity.barbeiro novoBarbeiro)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Barbeiros.Add(novoBarbeiro);
                _appDbContext.SaveChanges();
                requisicao.PRP_Sucesso = true;
                requisicao.PRP_Mensagem = $"Novo barbeiro cadastrado com sucesso. ID {novoBarbeiro.bar_id}";
            }
            catch (Exception ex)
            {
                requisicao.PRP_Mensagem = "Erro ao cadastrar novo barbeiro";
                requisicao.PRP_Sucesso = false;
            }

            return requisicao;
        }

        public Utils.RetornoRequisicao MTD_ExcluirBarbeiro(Entity.barbeiro BarbeiroAtualizado)
        {
            Utils.RetornoRequisicao requisicao = new Utils.RetornoRequisicao();
            try
            {
                _appDbContext.Remove(BarbeiroAtualizado);
                _appDbContext.SaveChanges();
                requisicao.PRP_Mensagem = "Barbeiro excluido com sucesso";
                requisicao.PRP_Sucesso = true;
            }
            catch (Exception ex)
            {

                requisicao.PRP_Mensagem = "Erro ao excluir o barbeiro";
                requisicao.PRP_Sucesso = false;
            }
            return requisicao;
        }

    }


}

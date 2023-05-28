using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_barbearia.Entity
{
    public class AppDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionString = Models.Utils.ValoresComuns.PRP_StringConexao;
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        /// <summary>
        /// Representa a tabela cliente na base de dados
        /// </summary>
        public DbSet<agendamento> Agendamentos { get; set; }
        public DbSet<barbeiro> Barbeiros { get; set; }
        public DbSet<barbeiro_agendamento> Barbeiro_Agendamento { get; set; }
        public DbSet<barbeiro_cliente> Barbeiro_Cliente { get; set; }
        public DbSet<barbeiro_servico> Barbeiro_Servicos { get; set; }
        public DbSet<cliente> Clientes { get; set; }
        public DbSet<servico> Servicos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_loja.Entidade;
using Microsoft.EntityFrameworkCore;

namespace Projeto_loja.DAO
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer("SERVER=DESKTOP-UQSM4T9\\HENRIQUE; DATABASE=ProjectDB; Integrated Security=true;");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

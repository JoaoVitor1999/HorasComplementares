using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoHorasCompl.Models;

namespace ProjetoHorasCompl.Data
{
    public class ProjetoHorasComplContext : DbContext
    {
        public ProjetoHorasComplContext (DbContextOptions<ProjetoHorasComplContext> options)
            : base(options)
        {
        }

        public DbSet<Turma> Turma { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Comprovante> Comprovante { get; set; }
        public DbSet<TipoComprovante> TipoComprovante { get; set; }
    }
}

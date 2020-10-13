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

        public DbSet<ProjetoHorasCompl.Models.Turma> Turma { get; set; }
    }
}

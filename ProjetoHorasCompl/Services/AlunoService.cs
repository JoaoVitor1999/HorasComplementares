using ProjetoHorasCompl.Data;
using ProjetoHorasCompl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHorasCompl.Services
{
    public class AlunoService
    {
        private readonly ProjetoHorasComplContext _context;
        public AlunoService(ProjetoHorasComplContext context)
        {
            _context = context;
        }

        public List<Aluno> SelecionarTodos()
        {
            return _context.Aluno.ToList();
        }
    }
}

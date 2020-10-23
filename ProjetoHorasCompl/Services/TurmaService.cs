using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ProjetoHorasCompl.Data;
using ProjetoHorasCompl.Models;

namespace ProjetoHorasCompl.Services
{
    public class TurmaService
    {
        private readonly ProjetoHorasComplContext _context;
        public TurmaService(ProjetoHorasComplContext context)
        {
            _context = context;
        }

        public List<Turma> SelecionarTurmas()
        {
            return _context.Turma.OrderBy(x => x.TurNome).ToList();
        }
    }
}

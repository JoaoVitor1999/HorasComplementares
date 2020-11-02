using ProjetoHorasCompl.Data;
using ProjetoHorasCompl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace ProjetoHorasCompl.Services
{
    public class ComprovanteService
    {
        private readonly ProjetoHorasComplContext _context;
        public ComprovanteService(ProjetoHorasComplContext context)
        {
            _context = context;
        }

        public async Task <List<Comprovante>> BuscaPorMatricula(int? aluMatricula) 
        {
            var result = from obj in _context.Comprovante select obj;
            if(aluMatricula != null)
            {
                result = result.Where(x => x.CmpAluId.Id == aluMatricula.Value);
            }

            return await result.Include(x => x.CmpAluId)
                .Include(x => x.CmpAluId.Turma)
                .ToListAsync();
        }
    }
}

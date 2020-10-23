using ProjetoHorasCompl.Data;
using ProjetoHorasCompl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        public Aluno SelecionarId(int id)
        {
            return _context.Aluno.Include(obj => obj.Turma).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remover (int id)
        {
            var obj = _context.Aluno.Find(id);
            _context.Aluno.Remove(obj);
            _context.SaveChanges();
        }
    }
}

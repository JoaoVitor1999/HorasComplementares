using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using ProjetoHorasCompl.Models;

namespace ProjetoHorasCompl.Data
{
    public class SeedingService
    {
        private ProjetoHorasComplContext _context;
        public SeedingService(ProjetoHorasComplContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Turma.Any() || _context.Aluno.Any() || _context.Comprovante.Any() || _context.TipoComprovante.Any())
            {
                return;
            }

            Turma t1 = new Turma(1, "Sistemas de Informação");

            Aluno a1 = new Aluno(19157001, "Joao", t1);

            TipoComprovante tc1 = new TipoComprovante(1,"Palestra");

            Comprovante c1 = new Comprovante(1,"Palestra IoT",new DateTime(2020, 10, 18),new DateTime(2020, 10, 18),3,a1,tc1);

            _context.Turma.Add(t1);
            _context.Aluno.Add(a1);
            _context.TipoComprovante.Add(tc1);
            _context.Comprovante.Add(c1);
            _context.SaveChanges();
        }
    }
}

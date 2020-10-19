using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHorasCompl.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string AluNome { get; set; }
        public Turma IdTurma { get; set; }
        public ICollection<Comprovante> Comprovantes { get; set; } = new List<Comprovante>();

        public Aluno()
        {
        }

        public Aluno(int id, string aluNome, Turma idTurma)
        {
            Id = id;
            AluNome = aluNome;
            IdTurma = idTurma;
        }

        public void AddComprovante(Comprovante sr)
        {
            Comprovantes.Add(sr);
        }

        public void RemoveComprovante(Comprovante sr)
        {
            Comprovantes.Remove(sr);
        }

        public int TotalComprovantes(int matricula)
        {
            return Comprovantes.Where(sr => sr.Id == matricula).Sum(sr => sr.CmpQtdHoras);
        }
    }
}

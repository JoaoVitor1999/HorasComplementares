using System.Collections.Generic;
using System;
using System.Linq;

namespace ProjetoHorasCompl.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string TurNome { get; set;}
        public ICollection<Aluno> TurAlunos { get; set; } = new List<Aluno>();

        public Turma()
        {
        }

        public Turma(int id, string turNome)
        {
            Id = id;
            TurNome = turNome;
        }

        public void AddAluno(Aluno aluno)
        {
            TurAlunos.Add(aluno);
        }
    }
}

using System.Collections.Generic;


namespace ProjetoHorasCompl.Models.ViewModels
{
    public class AlunoFormViewModel
    {
        public Aluno Aluno { get; set; }
        public ICollection<Turma> Turmas { get; set; }
    }
}

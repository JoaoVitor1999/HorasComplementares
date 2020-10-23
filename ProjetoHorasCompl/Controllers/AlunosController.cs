using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoHorasCompl.Data;
using ProjetoHorasCompl.Models.ViewModels;
using ProjetoHorasCompl.Models;
using ProjetoHorasCompl.Services;

namespace ProjetoHorasCompl.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AlunoService _alunoService;
        private readonly TurmaService _TurmaService;

        public AlunosController(AlunoService alunoService, TurmaService turmaService)
        {
            _alunoService = alunoService;
            _TurmaService = turmaService;
        }

        public IActionResult Index()
        {
            var list =_alunoService.SelecionarTodos();
            return View(list);
        }

        // GET: Alunos/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = _alunoService.SelecionarId(id.Value);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // GET: Alunos/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = _alunoService.SelecionarId(id.Value);
                
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _alunoService.Remover(id);
            return RedirectToAction(nameof(Index));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoHorasCompl.Services;

namespace ProjetoHorasCompl.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AlunoService _alunoService;

        public AlunosController(AlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        public IActionResult Index()
        {
            var list = _alunoService.SelecionarTodos();
            return View(list);
        }
    }
}

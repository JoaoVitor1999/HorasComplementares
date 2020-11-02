using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoHorasCompl.Services;

namespace ProjetoHorasCompl.Controllers
{
    public class ComprovantesController : Controller
    {

        private readonly ComprovanteService _comprovantesService;

        public ComprovantesController(ComprovanteService comprovantesService)
        {
            _comprovantesService = comprovantesService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(int? aluMatricula)
        {
            var result = await _comprovantesService.BuscaPorMatricula(aluMatricula);
            return View(result);
        }

        public IActionResult BuscaAgrupada()
        {
            return View();
        }
    }
}

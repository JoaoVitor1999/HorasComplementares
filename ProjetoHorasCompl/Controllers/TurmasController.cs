using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoHorasCompl.Models;

namespace ProjetoHorasCompl.Controllers
{
    public class TurmasController : Controller
    {
        public IActionResult Index()
        {
            List<Turma> list = new List<Turma>();
            list.Add(new Turma { TurCodigo = 1, TurNome = "Sistemas de Informação" });
            list.Add(new Turma { TurCodigo = 2, TurNome = "Engenharia Elétrica" });

            return View(list);
        }
    }
}

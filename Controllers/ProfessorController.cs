using Microsoft.AspNetCore.Mvc;
using lab3.Models;

namespace lab3.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            Professor professor = new Professor();
            professor.CriarProfessor();

            return View(professor.BuscarProfessor());
        }
    }
}
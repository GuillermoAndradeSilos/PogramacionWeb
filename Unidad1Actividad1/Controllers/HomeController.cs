using Microsoft.AspNetCore.Mvc;
using Unidad1Actividad1.Models;

namespace Unidad1Actividad1.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MiPerfil(PerfilViewModel info){
            DateTime comparar = new(0001,01,01);
            int resultado = DateTime.Compare(info.Periodo,comparar);
            if( (resultado==0) ||string.IsNullOrWhiteSpace(info.NombreAlumno) || string.IsNullOrWhiteSpace(info.NombreMateria) || (info.Semestre ==0) )
                return RedirectToAction("Index");
            else
                return View(info);
        }
    }
}
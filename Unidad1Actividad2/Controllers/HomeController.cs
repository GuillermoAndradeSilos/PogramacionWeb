using Microsoft.AspNetCore.Mvc;

namespace Unidad1Actividad2.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index(decimal calificacion, decimal calificacion2, decimal calificacion3)
        {
            decimal promedio=(calificacion+calificacion2+calificacion3)/3;
            string estado;
            string calificacionespasadas=$"calificacion/{calificacion.ToString()}/calificacion2/{calificacion2.ToString()}/calificacion3/{calificacion3.ToString()}";
            if(promedio<70)
                estado="Reprobado";
            else
                estado="Aprobado";
            object enviar = calificacionespasadas+"/"+promedio.ToString()+"/"+estado;
            return View(enviar);
        }
    }
}
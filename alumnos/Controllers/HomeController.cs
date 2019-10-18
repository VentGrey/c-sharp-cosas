using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using alumnos.Models;

namespace alumnos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno {
                NUA = "203635",
                Nombre = "Omar Jair",
                PrimerApellido = "Purata",
                SegundoApellido = "Funes",
                Genero = "Vato",
            });

            alumnos.Add(new Alumno {
                NUA = "202329",
                Nombre = "Estephania",
                PrimerApellido = "Gonzalez",
                SegundoApellido = "Vargas",
                Genero = "Morra",
            });
            return View(alumnos);
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

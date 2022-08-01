using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento { Id = 1, Nome = "Eletronicos"});
            lista.Add(new Departamento { Id = 2, Nome = "Moda" });

            return View(lista);
        }
    }
}

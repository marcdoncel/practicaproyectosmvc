using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositorios;

namespace PracticaProyectosMVC.Controllers
{
    public class EmpleadosController : BaseController
    {
        // GET: Empleados
        public ActionResult Empleados()
        {
            var data = RepositorioEmpleado.Get();
            return View(data);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaProyectosMVC.Models;
using PracticaProyectosMVC.Models.ViewModels;

namespace PracticaProyectosMVC.Controllers
{
    public class ProyectosController : BaseController
    {
        // GET: Proyectos
        public ActionResult Index()
        {
            var data = RepositorioProyecto.Get();
            return View(data);
        }

        public ActionResult NuevoProyecto()
        {
            ViewBag.Errores = false;
            return View(new ProyectosViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NuevoProfesor(ProyectosViewModel model)
        {
            if (ModelState.IsValid)
            {
                RepositorioProyecto.Add(model);
                RedirectToAction("Index");
            }
            ViewBag.Errores = true;
            return View(model);
        }

    }
}
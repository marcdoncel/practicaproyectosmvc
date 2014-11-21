using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaProyectosMVC.Models;
using PracticaProyectosMVC.Models.ViewModels;
using Repositorios;

namespace PracticaProyectosMVC.Controllers
{
    public class BaseController : Controller
    {
        private DatosEmpleadosEntities _db;
        #region RepositorioProyectos

        private IRepositorio<ProyectosViewModel, Proyecto> _repositorioProyecto;

        public IRepositorio<ProyectosViewModel, Proyecto> RepositorioProyecto
        {
            get
            {
                if (_repositorioProyecto ==null)
                    _repositorioProyecto = new Repositorio<ProyectosViewModel, Proyecto>(_db);
                return _repositorioProyecto;
            }
        }

        public BaseController()
        {
            _db = new DatosEmpleadosEntities();
        }
        #endregion
        #region RepositorioEmpleados

        private IRepositorio<EmpleadosViewModel, Empleado> _repositorioEmpleado;
        public IRepositorio<EmpleadosViewModel, Empleado> RepositorioEmpleado
        {
            get
            {
                if (_repositorioEmpleado == null)
                    _repositorioEmpleado = new Repositorio<EmpleadosViewModel, Empleado>(_db);
                return _repositorioEmpleado;
            }
        }
        #endregion
    }
}
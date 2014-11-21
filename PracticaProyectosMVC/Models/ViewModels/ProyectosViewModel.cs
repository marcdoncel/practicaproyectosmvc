using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using Repositorios;

namespace PracticaProyectosMVC.Models.ViewModels
{
    public class ProyectosViewModel:IViewModel<Proyecto>
    {
        public int idProyecto { get; set; }
        [Required]
        public String nombre { get; set; }
        [Required]
        public String descripcion { get; set; }
        public String cliente { get; set; }
        
        public Proyecto ToBaseDatos()
        {
            var model = new Proyecto()
            {
                nombre = nombre,
                descripcion = descripcion,
                cliente = cliente
            };
            return model;
        }

        public void FromBaseDatos(Proyecto model)
        {
            nombre = model.nombre;
            descripcion = model.descripcion;
            cliente = model.cliente;
        }

        public void UpdateBaseDatos(Proyecto model)
        {
            model.nombre = nombre;
            model.descripcion = descripcion;
            model.cliente = cliente;
        }

        public int[] GetPk()
        {
            return new[] {idProyecto};
        }
    }
}
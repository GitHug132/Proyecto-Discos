using ProyectoDiscos.DataAccessLayer;
using ProyectoDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoDiscos.Controllers
{
    public class ListaController : Controller
    {
        // GET: Lista
        //obtiene la lista de puntuaciones y de discos
        public ActionResult Lista()
        {
            List<Puntuacion> Puntuacion;
            using (var context = new DiscosDAL())
            {
                Puntuacion = context.Puntuaciones.Include("Disco").ToList();
                
            }
            return View(Puntuacion);
        }

        //Inserta una nueva puntuación en la base de datos
        [HttpPost]
        public void Puntuar(Puntuacion puntuacion)
        {
            DateTime date = DateTime.Now;
            puntuacion.Fecha = date;
            if (ModelState.IsValid)
            {
                using (var context = new DiscosDAL())
                {
                    context.Puntuaciones.Add(puntuacion);
                    context.SaveChanges();
                }

            }
        }
    }
}
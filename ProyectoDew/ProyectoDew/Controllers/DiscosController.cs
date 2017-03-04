using ProyectoDew.DataAccessLayer;
using ProyectoDew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoDew.Controllers
{
    public class DiscosController : ApiController
    {
        //GET: api/Discos
        public List<Object> GetDiscos()
        {

            using (var context = new DiscosDAL())
            {
                var query = from Disco in context.Discos
                            join Interprete in context.Interpretes
                            on Disco.IdInterprete equals Interprete.IdInterprete
                            join Puntuacion in context.Puntuaciones
                            on Disco.IdDisco equals Puntuacion.iddisco
                            join DiscoTipo in context.DiscoTipo
                            on Disco.IdDisco equals DiscoTipo.IdDisco
                            join Tipo in context.Tipo
                            on DiscoTipo.IdTipo equals Tipo.IdTipo
                            select new
                            {
                                Disco,
                                Interprete = Interprete.Interprete1,
                                Tipo = Tipo.tipo1,
                                Puntuacion = Puntuacion.Puntuacion1
                                /*Disco.IdDisco,
                                Disco.Titulo,
                                Disco.Agno,
                                Interprete.Interprete1,
                                Puntuacion.Puntuacion1,
                                Tipo.tipo1*/
                            };

                return query.ToList<Object>();
               
            }

        }
        // 
        //GetDiscosTop: Nombre y puntuacion
        //
        //GetPuntuaciones: Media de todas las puntuaciones de cada disco
    }
}

using ProyectoDiscos.DataAccessLayer;
using ProyectoDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoDiscos.Controllers
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
                            group Puntuacion by new
                            {
                                Disco.IdDisco,
                                Disco.Titulo,
                                Disco.Agno,
                                Interprete.Interprete1
                                //Tipo.tipo1
                            } into grouping
                            select new
                            {
                                grouping.Key.IdDisco,
                                //grouping.Key.Titulo,
                                grouping.Key.Agno,
                                grouping.Key.Interprete1,
                                Puntuacion = grouping.Average(x => x.Puntuacion1)
                            }; ;

                return query.ToList<Object>();
               
            }

        }
    }
}

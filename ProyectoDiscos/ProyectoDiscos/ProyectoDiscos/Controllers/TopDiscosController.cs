using ProyectoDiscos.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoDiscos.Controllers
{
    public class TopDiscosController : ApiController
    {
        //GET: api/TopDiscos
        public List<Object> GetTopDiscos()
        {

            using (var context = new DiscosDAL())
            {
                var query = (from Disco in context.Discos
                             join Puntuacion in context.Puntuaciones
                             on Disco.IdDisco equals Puntuacion.iddisco
                             group Puntuacion by new
                             {
                                 Disco.IdDisco,
                                 Disco.Titulo,
                             } into grouping
                             orderby grouping.Average(x => x.Puntuacion1) descending
                             select new
                             {
                                 grouping.Key.IdDisco,
                                 grouping.Key.Titulo,
                                 Puntuacion = grouping.Average(x => x.Puntuacion1),
                             }).Take(5); ;

                return query.ToList<Object>();

            }

        }
    }
}

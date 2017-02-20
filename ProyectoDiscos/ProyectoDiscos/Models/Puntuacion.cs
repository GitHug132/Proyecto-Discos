using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoDiscos.Models
{
    public class Puntuacion
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> Idcliente { get; set; }
        public Nullable<int> iddisco { get; set; }
        public Nullable<int> Puntuacion1 { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Disco Disco { get; set; }
    }
}
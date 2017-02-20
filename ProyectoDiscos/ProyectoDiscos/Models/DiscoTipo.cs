using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDiscos.Models
{
    public class DiscoTipo
    {
        public int Id { get; set; }
        public Nullable<int> IdDisco { get; set; }
        public Nullable<int> IdTipo { get; set; }

        public virtual Disco Disco { get; set; }
        public virtual Tipo Tipo { get; set; }
    }
}
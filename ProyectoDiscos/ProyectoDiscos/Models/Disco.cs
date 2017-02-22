using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDiscos.Models
{
    public class Disco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disco()
        {
            this.DiscoTipo = new HashSet<DiscoTipo>();
            this.Puntuacion = new HashSet<Puntuacion>();
        }

        public int IdDisco { get; set; }
        public string Titulo { get; set; }
        public Nullable<double> Agno { get; set; }
        public Nullable<int> IdInterprete { get; set; }

        public virtual Interprete Interprete { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscoTipo> DiscoTipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Puntuacion> Puntuacion { get; set; }
    }
}
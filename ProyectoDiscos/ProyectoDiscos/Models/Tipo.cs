using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDiscos.Models
{
    public class Tipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo()
        {
            this.DiscoTipo = new HashSet<DiscoTipo>();
        }

        public int IdTipo { get; set; }
        public string tipo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscoTipo> DiscoTipo { get; set; }
    }
}
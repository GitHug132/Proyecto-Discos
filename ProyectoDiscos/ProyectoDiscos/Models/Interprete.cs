using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDiscos.Models
{
    public class Interprete
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Interprete()
        {
            this.Disco = new HashSet<Disco>();
        }

        public string Interprete1 { get; set; }
        public int IdInterprete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Disco> Disco { get; set; }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoDiscos.Models
{
    public class Disco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disco()
        {

        }
        [Key]
        public int IdDisco { get; set; }
        public string Titulo { get; set; }
        public Nullable<double> Agno { get; set; }
        public Nullable<int> IdInterprete { get; set; }
        
        [ForeignKey("IdInterprete")]
        [JsonIgnore]
        public virtual Interprete Interprete { get; set; }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoDew.Models
{
    public class DiscoTipo
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> IdDisco { get; set; }
        public Nullable<int> IdTipo { get; set; }
        [ForeignKey("IdDisco")]
        [JsonIgnore]
        public virtual Disco Disco { get; set; }
        [ForeignKey("IdTipo")]
        [JsonIgnore]
        public virtual Tipo Tipo { get; set; }
    }
}
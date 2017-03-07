using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoDiscos.Models
{
    public class Puntuacion
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Idcliente de cliente no válido")]
        public Nullable<int> Idcliente { get; set; }
        [Required(ErrorMessage = "iddisco de cliente no válido")]
        public Nullable<int> iddisco { get; set; }

        [Column("Puntuacion")]
        [Required(ErrorMessage = "Puntuacion de cliente no válido")]
        public Nullable<int> Puntuacion1 { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }

        [ForeignKey("Idcliente")]
        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("iddisco")]
        [JsonIgnore]
        public virtual Disco Disco { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoDiscos.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "Login requerido")]
        public string nombreUsuario { get; set; }
        [Required(ErrorMessage = "Password requerida")]
        public Nullable<System.DateTime> Password { get; set; }
    }
}
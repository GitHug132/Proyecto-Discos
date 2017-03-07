using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoDiscos.Models
{
    public class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Puntuacion = new HashSet<Puntuacion>();
        }
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Nombre de usuario no válido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Email de usuario no válido")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password no válido")]
        public string Password { get; set; }
        [Required(ErrorMessage = "FechaNacimiento de usuario no válido")]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Puntuacion> Puntuacion { get; set; }
    }
}
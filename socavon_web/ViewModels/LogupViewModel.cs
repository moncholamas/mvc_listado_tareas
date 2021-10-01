using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace socavon_web.ViewModels
{
    public class LogupViewModel
    {
        [Required(ErrorMessage = "El nombre es un campo requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es un campo requerido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El correo es un campo requerido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La clave es un campo requerido")]
        public string Clave { get; set; }

        [Required(ErrorMessage = "La clave es un campo requerido")]
        public string ClaveVerificada { get; set; }

    }
}

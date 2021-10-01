using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace socavon_web.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El correo es un campo obligatorio")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La clave es un campo obligatorio")]
        public string Clave { get; set; }
    }
}

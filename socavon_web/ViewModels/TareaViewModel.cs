using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace socavon_web.ViewModels
{
    public class TareaViewModel
    {

        [Required(ErrorMessage = "El título es un campo requerido")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "La prioridad es un campo requerido")]
        public string Priority { get; set; }


    }
}

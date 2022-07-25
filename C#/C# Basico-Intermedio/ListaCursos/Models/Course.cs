using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCursos.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="El nombre el requerido")]
        [Display (Name= "Nombre")]
        public string Name { get; set; }
        
        [MaxLength(500, ErrorMessage="El numero maximo de caracteres son 500")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [Required (ErrorMessage = "El(la) es requerido")]
        [Display(Name = "Autor")]
        public string Author { get; set; }
        [Url(ErrorMessage ="la direccion no es valida")]
        [Display(Name = "URL")]
        public string Uri { get; set; }
    }
}

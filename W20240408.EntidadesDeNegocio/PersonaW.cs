using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W20240408.EntidadesDeNegocio
{
    public class PersonaW
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [Display(Name ="Nombre")]
        public string NombreW { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Apellido")]
        public string ApellidoW { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimientoW { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Sueldo")]
        public decimal SueldoW { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estatus")]
        public byte  EstatusW { get; set; }
        [Display(Name = "Comentario")]
        public string ComentarioW { get; set; }
    }
}

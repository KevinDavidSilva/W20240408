using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W20240408.EntidadesDeNegocio
{
    public class PersonaW
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string NombreW { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string ApellidoW { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime FechaNacimientoW { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal SueldoW { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public byte  EstadusW { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string ComentarioW { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpticelular.Modelos
{
    public class Almacen
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Descripcion es Requerido")]
        [MaxLength(60)]
        public string Descripcion { get; set; }
        public bool Status { get; set; }
    }
}

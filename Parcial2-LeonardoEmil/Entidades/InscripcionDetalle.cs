using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LeonardoEmil.Entidades
{
   public class InscripcionDetalle
    {
        [Key]
        public int InscripcionDetalleId { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; }
        public decimal SubTotal { get; set; }

       // [ForeignKey("EstudianteId")]
       // public virtual Estudiantes Estudiante { get; set; }

        public InscripcionDetalle()
        {
            InscripcionDetalleId = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            SubTotal = 0;
        }

        public InscripcionDetalle(int inscripcionDetalleId, int inscripcionId, int asignaturaId, decimal subTotal)
        {
            InscripcionDetalleId = inscripcionDetalleId;
            InscripcionId = inscripcionId;
            AsignaturaId = asignaturaId;
            SubTotal = subTotal;
        }
    }
}

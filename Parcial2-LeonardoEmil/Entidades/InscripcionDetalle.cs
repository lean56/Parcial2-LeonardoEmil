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
        public int EstudianteId { get; set; }
        public decimal Monto { get; set; }

        [ForeignKey("EstudianteId")]
        public virtual Estudiantes Estudiante { get; set; }

        public InscripcionDetalle()
        {
            InscripcionDetalleId = 0;
            InscripcionId = 0;
            EstudianteId = 0;
            Monto = 0;
        }

        public InscripcionDetalle(int inscripcionDetalleId, int inscripcionId, int estudianteId, decimal monto, Estudiantes estudiante)
        {
            InscripcionDetalleId = inscripcionDetalleId;
            InscripcionId = inscripcionId;
            EstudianteId = estudianteId;
            Monto = monto;
            Estudiante = estudiante;
        }
    }
}

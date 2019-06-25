using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LeonardoEmil.Entidades
{
   public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public virtual List<InscripcionDetalle> Detalle { get; set; }

        public Inscripciones(int inscripcionId, DateTime fecha, decimal monto, List<InscripcionDetalle> detalle)
        {
            InscripcionId = inscripcionId;
            Fecha = fecha;
            Monto = monto;
            this.Detalle = detalle;
        }

        public Inscripciones()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            this.Detalle = new List<InscripcionDetalle>();
        }
    }
}

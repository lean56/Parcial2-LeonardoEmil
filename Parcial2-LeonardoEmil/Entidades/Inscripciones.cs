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
        public int EstudianteId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public decimal Monto { get; set; }

        public virtual List<InscripcionDetalle> Detalle { get; set; }

        public Inscripciones(int inscripcionId, DateTime fecha,int precio, decimal monto)
        {
            InscripcionId = inscripcionId;
            Fecha = fecha;
            Precio = precio;
            Monto = monto;
        }

        public Inscripciones()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Precio = 0;
            Monto = 0;
            this.Detalle = new List<InscripcionDetalle>();
        }
    }
}

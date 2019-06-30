using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LeonardoEmil.Entidades
{
  public class Calculos
    {
        public static void CalcularMonto()
        {
            Inscripciones inscripcion = new Inscripciones();
            decimal total = 0;

            foreach (var item in inscripcion.Detalle)
            {
                total += item.SubTotal;
            }

            inscripcion.Monto = total;
        }
    }
}

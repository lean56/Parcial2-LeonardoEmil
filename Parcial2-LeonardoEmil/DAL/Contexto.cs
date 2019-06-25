using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LeonardoEmil.DAL
{
   public class Contexto : DbContext
    {
        public DbSet<Asignatura>asignatura { get; set; }
        public DbSet<Estudiante>estudiante { get; set; }
        public DbSet<Inscripcion>inscripcion { get; set; }

        public Contexto() : base("Constr") { }
    }
}

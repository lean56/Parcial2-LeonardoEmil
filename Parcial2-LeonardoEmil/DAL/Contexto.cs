using Parcial2_LeonardoEmil.Entidades;
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
        public DbSet<Asignaturas>Asignatura { get; set; }
        public DbSet<Estudiantes>Estudiante { get; set; }
        public DbSet<Inscripciones>Inscripcion { get; set; }

        public Contexto() : base("Constr") { }

        public void FixEfProviderServicesProblem()
        {
            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}

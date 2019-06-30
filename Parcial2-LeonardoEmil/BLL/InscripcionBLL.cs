using Parcial2_LeonardoEmil.DAL;
using Parcial2_LeonardoEmil.Entidades;
using Parcial2_LeonardoEmil.UI.Registro;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LeonardoEmil.BLL
{
   public class InscripcionBLL : RepositorioBase<Inscripciones>
    {
        public override bool Guardar(Inscripciones entity)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                RepositorioBase<Estudiantes> dbE = new RepositorioBase<Estudiantes>();

                if (db.Inscripcion.Add(entity) != null)
                {
                    var estudiante = dbE.Buscar(entity.EstudianteId);
                    estudiante.Balance += entity.Monto;

                    paso = db.SaveChanges() > 0;
                    dbE.Modificar(estudiante);
                }

            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }

        public static Inscripciones Buscar(int id)
        {

            Inscripciones mantenimiento = new Inscripciones();
            Contexto contexto = new Contexto();

            try
            {
                mantenimiento = contexto.Inscripcion.Find(id);
              
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return mantenimiento;

        }

        public override bool Modificar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            RepositorioBase<Estudiantes> repositorioEst = new RepositorioBase<Estudiantes>();

            try
            {
                var estudiante = repositorioEst.Buscar(inscripcion.EstudianteId);

           //     var anterior = new RepositorioBase<Inscripciones>().Buscar(inscripcion.InscripcionId);

               // estudiante.Balance -= anterior.Monto;

                foreach(var item in inscripcion.Detalle)
                {
                    contexto.Estudiante.Find(item.EstudianteId).Balance += item.Monto;
                    if(!inscripcion.Detalle.ToList().Exists(p => p.InscripcionDetalleId == item.EstudianteId))
                    {
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach(var item in inscripcion.Detalle)
                {
                    if (item.InscripcionDetalleId == 0)
                    {
                        contexto.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        contexto.Entry(inscripcion).State = EntityState.Modified;
                    }
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

    

        public static bool Modifica2r(Inscripciones mantenimiento)
        {

            bool paso = false;

            Contexto contexto = new Contexto();
            var Mantenimiento = Buscar(mantenimiento.EstudianteId);
            try
            {
                if (Mantenimiento != null)
                {
                    foreach (var item in Mantenimiento.Detalle)
                    {

                        contexto.Estudiante.Find(item.EstudianteId).Balance += item.Monto;


                        if (!mantenimiento.Detalle.ToList().Exists(v => v.InscripcionId == item.EstudianteId))
                        {
                            // contexto.Articulo.Find(item.ArticuloId).Cantidad -= item.Cantidad;

                            item.Estudiante = null;
                            contexto.Entry(item).State = EntityState.Deleted;
                        }
                    }

                    if (contexto.SaveChanges() > 0)
                    {
                        paso = true;
                    }
                    contexto.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

       
    }
}

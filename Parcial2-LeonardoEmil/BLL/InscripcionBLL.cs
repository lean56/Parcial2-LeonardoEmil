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
            Contexto contexto = new Contexto();

            try
            {
                RepositorioBase<Estudiantes> repositorioEst = new RepositorioBase<Estudiantes>();

                if (contexto.Inscripcion.Add(entity) != null)
                {
                    var estudiante = repositorioEst.Buscar(entity.EstudianteId);
                    entity.CalcularMonto();
                    estudiante.Balance += entity.Monto;

                    paso = contexto.SaveChanges() > 0;
                    repositorioEst.Modificar(estudiante);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }


        public override bool Modificar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            RepositorioBase<Estudiantes> repositorioEst = new RepositorioBase<Estudiantes>();

            try
            {
                var estudiante = repositorioEst.Buscar(inscripcion.EstudianteId);
                var anterior = new RepositorioBase<Inscripciones>().Buscar(inscripcion.InscripcionId);
                estudiante.Balance -= (decimal)anterior.Monto;

                foreach (var item in anterior.Detalle)
                {
                    if (!inscripcion.Detalle.Any(p => p.InscripcionDetalleId == item.InscripcionDetalleId))
                    {
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in inscripcion.Detalle)
                {
                    if (item.InscripcionDetalleId == 0)
                    {
                        contexto.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        contexto.Entry(item).State = EntityState.Modified;
                    }
                }

                inscripcion.CalcularMonto();
                estudiante.Balance += (decimal)inscripcion.Monto;
                repositorioEst.Modificar(estudiante);

                contexto.Entry(inscripcion).State = EntityState.Modified;

                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public override bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Estudiantes> repositorioEst = new RepositorioBase<Estudiantes>();
            try
            {
                var Inscripcion = db.Inscripcion.Find(id);
                var estudiante = repositorioEst.Buscar(Inscripcion.EstudianteId);

                estudiante.Balance = estudiante.Balance - Inscripcion.Monto;

                repositorioEst.Modificar(estudiante);

                db.Entry(Inscripcion).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
    }
}





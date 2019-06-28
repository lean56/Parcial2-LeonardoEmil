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
   public class InscripcionBLL 
    {
        public static bool Guardar(Inscripciones entity)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                Inscripciones inscripcion = new Inscripciones();
                Estudiantes estudiante = new Estudiantes();
                if(db.inscripcion.Add(entity) !=null)
                {

                foreach(var item in inscripcion.Detalle)
                    {
                        db.estudiante.Find(item.EstudianteId).Balance += item.Monto;
                    }
                    db.inscripcion.Find(inscripcion.EstudianteId).Monto += estudiante.Balance;

                    //  est.Balance +=Monto;
                    paso = db.SaveChanges() > 0;
                    
                }
            }
            catch(Exception)
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
                mantenimiento = contexto.inscripcion.Find(id);
              
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return mantenimiento;

        }

        public static bool Modificar(Inscripciones mantenimiento)
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

                        contexto.estudiante.Find(item.EstudianteId).Balance += item.Monto;


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

        public static void ActualizarBalance()
        {
            Estudiantes estudiante = new Estudiantes();

            rInscripcion ri = new rInscripcion();
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();

            int id = Convert.ToInt32(ri.AsignaturacomboBox.SelectedValue);

            int est = Convert.ToInt32(ri.EstudiantecomboBox.SelectedValue);

            asignatura = repositorio.Buscar(id);
            
              estudiante.Balance += ri.MontonumericUpDown.Value;
     

        }
    }
}

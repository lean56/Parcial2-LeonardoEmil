using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_LeonardoEmil.Entidades;

namespace Parcial2_LeonardoEmil.BLL.Tests
{
    [TestClass()]
    public class AsignaturasTest
    {
    
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura = new Asignaturas()
            {
                AsignaturaId = 1,
                Descripcion = "Prueba 1",
                Creditos = 2
            };

            Assert.IsTrue(db.Guardar(asignatura));
        }

        [TestMethod()]
        public void GuardarConDetalleTest()
        {

            RepositorioBase<InscripcionDetalle> db = new RepositorioBase<InscripcionDetalle>();

            InscripcionDetalle detalle = new InscripcionDetalle()
            {
                InscripcionDetalleId = 1,
                InscripcionId = 1,
                EstudianteId = 1,
                Monto = 1000
        };
            

        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura = new Asignaturas()
            {
                AsignaturaId = 1,
                Descripcion = "Programacion Aplicada",
                Creditos = 3
            };

            Assert.IsTrue(db.Modificar(asignatura));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            Assert.IsNotNull(db.GetList(t => true));
        }

     
    }
}
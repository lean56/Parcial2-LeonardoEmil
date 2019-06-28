using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_LeonardoEmil.BLL;
using Parcial2_LeonardoEmil.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LeonardoEmil.BLL.Tests
{
    [TestClass()]
    public class EstudiantesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Estudiantes estudiante = new Estudiantes()
            {
                EstudianteId = 1,
                FechaIngreso = DateTime.Now,
                Nombres = "Juan Perez",
                Balance = 1000
            };

            Assert.IsTrue(db.Guardar(estudiante));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Estudiantes estudiante = new Estudiantes()
            {
                EstudianteId = 1,
                FechaIngreso = DateTime.Now,
                Nombres = "Juan Perez H",
                Balance = 10500
            };

            Assert.IsTrue(db.Modificar(estudiante));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Assert.IsNotNull(db.GetList(t => true));
        }

    }
}
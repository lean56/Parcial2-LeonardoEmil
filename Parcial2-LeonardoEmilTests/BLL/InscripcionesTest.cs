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
    public class InscripcionesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();

            Inscripciones inscripcion = new Inscripciones()
            {
                InscripcionId = 1,
                Fecha = DateTime.Now,
                Monto = 1000
            };

            Assert.IsTrue(db.Guardar(inscripcion));
        }



        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();

            Inscripciones inscripcion = new Inscripciones()
            {
                InscripcionId = 1,
                Fecha = DateTime.Now,
                Monto = 10500
            };

            Assert.IsTrue(db.Modificar(inscripcion));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();

            Assert.IsNotNull(db.GetList(t => true));
        }
    }
}
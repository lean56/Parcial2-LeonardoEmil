using Parcial2_LeonardoEmil.BLL;
using Parcial2_LeonardoEmil.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_LeonardoEmil.UI.Registro
{
    public partial class rAsignatura1 : Form
    {
        public rAsignatura1()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CreditonumericUpDown.Value = 0;
        }


        private Asignaturas LlenaClase()
        {
            Asignaturas asignatura = new Asignaturas()
            {
                AsignaturaId = (int)IdnumericUpDown.Value,
                Descripcion = DescripciontextBox.Text,
                Creditos = (int)CreditonumericUpDown.Value
            };
            return asignatura;
        }

        private void LlenaCampo(Asignaturas asignatura)
        {
            IdnumericUpDown.Value = asignatura.AsignaturaId;
            DescripciontextBox.Text = asignatura.Descripcion;
            CreditonumericUpDown.Value = asignatura.Creditos;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (asignatura != null);
        }

        private bool Validar()
        {
            bool paso = true;
            RepositorioBase<Asignaturas> repositorioA = new RepositorioBase<Asignaturas>();

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                ErrorProvider.SetError(DescripciontextBox, "Este Campo No puede Estar Vacio!!");
                paso = false;
            }
            if (CreditonumericUpDown.Value == 0)
            {
                ErrorProvider.SetError(CreditonumericUpDown, "Este Campo No puede Ser Cero");
                paso = false;
            }
            if(repositorioA.Duplicado(p => p.Descripcion == DescripciontextBox.Text))
            {
                ErrorProvider.SetError(DescripciontextBox, "Esta Asignatura Ya existe!!!");
                paso = false;
            }
            
            return paso;
        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();

            int.TryParse(IdnumericUpDown.Text, out int id);

            asignatura = repositorio.Buscar(id);

            if (asignatura != null)
            {
                ErrorProvider.Clear();
                LlenaCampo(asignatura);
            }
            else
                ErrorProvider.SetError(IdnumericUpDown, "Asignatura no Encontrada");
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura;
            bool paso = false;

            if (!Validar())
                return;

            asignatura = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(asignatura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Asignatura que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(asignatura);
            }

            if (paso)
            {
                MessageBox.Show("Asignatura Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            ErrorProvider.Clear();

            int.TryParse(IdnumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                ErrorProvider.SetError(IdnumericUpDown, "Asignatura no Existe!!!");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Asignatura Eliminada!!", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

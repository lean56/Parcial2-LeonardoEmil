using Parcial2_LeonardoEmil.Entidades;
using Parcial2_LeonardoEmil.BLL;
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
    public partial class rEstudiantes : Form
    {
        RepositorioBase<Estudiantes> repositorio;
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes()
            {
                EstudianteId = Convert.ToInt32(IdnumericUpDown.Value),
                Nombres = NombretextBox.Text,
                FechaIngreso = FechadateTimePicker.Value,
                Balance = BalancenumericUpDown.Value
            };
            return estudiante;
        }

        private void LlenaCampo(Estudiantes estudiante)
        {
            IdnumericUpDown.Value = estudiante.EstudianteId;
            NombretextBox.Text = estudiante.Nombres;
            FechadateTimePicker.Value = estudiante.FechaIngreso;
            BalancenumericUpDown.Value = estudiante.Balance;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (estudiante != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Estudiantes>();

            Estudiantes estudiante;
            bool paso = false;

            estudiante = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un paciente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }   
                paso = repositorio.Modificar(estudiante);
            }
            if(paso)
            {
                MessageBox.Show("Vendedor Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        

        }
    }
}

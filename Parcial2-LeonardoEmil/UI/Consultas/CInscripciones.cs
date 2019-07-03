using Parcial2_LeonardoEmil.BLL;
using Parcial2_LeonardoEmil.Entidades;
using Parcial2_LeonardoEmil.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_LeonardoEmil.UI.Consultas
{
    public partial class cInscripciones : Form
    {
        private List<Inscripciones> listaInscripcion;

        public cInscripciones()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(FiltroComboBox, "No ha selecionado ningun filtro");
                FiltroComboBox.Focus();
                paso = false;
            }

            if (CristerioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CristerioTextBox, "El campo Criterio esta vacio");
                CristerioTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void ConsultaUserbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Inscripciones>();
            RepositorioBase<Inscripciones> repositorioI = new RepositorioBase<Inscripciones>();

            if (!Validar())
                return;

            if (CristerioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo: todo
                        listado = repositorioI.GetList(p => true);
                        Imprimirbutton.Visible = true;
                        break;
                    case 1: //Todo: ID Inscripcion
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorioI.GetList(p => p.InscripcionId == id);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                    case 2://Todo: Id Estudiante
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int Id = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorioI.GetList(p => p.EstudianteId == Id);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                    case 3://Todo: IdAsignatura
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int ID = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorioI.GetList(p => p.AsignaturaId == ID);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                    case 4://Todo: Monto
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int Monto = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorioI.GetList(p => p.Monto == Monto);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                }
                listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorioI.GetList(p => true);
            }
            cAsignaturadataGridView.DataSource = null;
            listaInscripcion = repositorioI.GetList(p => true);
            cAsignaturadataGridView.DataSource = listado;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if(listaInscripcion.Count ==0)
            {
                MessageBox.Show("No Hay Datos para imprimir");
                return;
            }
            else
            {
                rptInscripcion rpti = new rptInscripcion(listaInscripcion);
                rpti.ShowDialog();
            }
        }
    }
}

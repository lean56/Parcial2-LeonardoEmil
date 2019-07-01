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

namespace Parcial2_LeonardoEmil.UI.Consultas
{
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(FiltroComboBox, "No a selecionado ningun filtro");
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
            var listado = new List<Estudiantes>();
            RepositorioBase<Estudiantes> repositorioA = new RepositorioBase<Estudiantes>();

            if (!Validar())
                return;

            if (CristerioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo: todo
                        listado = repositorioA.GetList(p => true);
                        break;
                    case 1: //Todo: ID
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorioA.GetList(p => p.EstudianteId == id);
                        }
                        break;
                    case 2://Todo: Nombres
                        listado = repositorioA.GetList(p => p.Nombres.Contains(CristerioTextBox.Text));
                        break;
                }
                listado = listado.Where(c => c.FechaIngreso.Date >= DesdedateTimePicker.Value.Date && c.FechaIngreso.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorioA.GetList(p => true);
            }
            
            cAsignaturadataGridView.DataSource = null;
            cAsignaturadataGridView.DataSource = listado;
           
        }
    }
}

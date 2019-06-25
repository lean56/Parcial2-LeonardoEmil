using Parcial2_LeonardoEmil.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_LeonardoEmil
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes re = new rEstudiantes();
            re.Show();
        }

        private void registroAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignatura ra = new rAsignatura();
            ra.Show();
        }
    }
}

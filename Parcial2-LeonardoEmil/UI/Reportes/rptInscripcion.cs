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

namespace Parcial2_LeonardoEmil.UI.Reportes
{
    public partial class rptInscripcion : Form
    {
         List<Inscripciones> ListadoInscripcion = new List<Inscripciones>();
        public rptInscripcion(List<Inscripciones>Linscripcion)
        {
            InitializeComponent();
            ListadoInscripcion = Linscripcion;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrInscripcion rpt = new CrInscripcion();
            rpt.SetDataSource(ListadoInscripcion);
            InscripcioncrystalReportViewer.ReportSource = rpt;
            InscripcioncrystalReportViewer.Refresh();

        }
    }
}

using Parcial2_LeonardoEmil.UI.Consultas;
using Parcial2_LeonardoEmil.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_LeonardoEmil
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 200)
            {
                MenuVertical.Width = 50;
            }
            else
                MenuVertical.Width = 200;
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            Max.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Max_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Max.Visible = false;
            restaurar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void RegistroAsignatura_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rAsignatura());
        }

        private void RegistroEstudiante_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rEstudiantes());
        }

        private void RegistroInscripcion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rInscripcion());
        }

        private void RegistroAsignatura_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rAsignatura());
        }

        private void ConsultaAbutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cAsignaturas());
        }

        private void cEstudiantesbutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cEstudiantes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cInscripciones());
        }
    }
}

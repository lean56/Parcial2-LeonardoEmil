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
    public partial class rInscripcion : Form
    {
        RepositorioBase<Inscripciones> repositorio;

        List<InscripcionDetalle> detalle = new List<InscripcionDetalle>();
        public List<InscripcionDetalle> detalles { get; set; }

        public rInscripcion()
        {
            InitializeComponent();
            LlenarComboBoxEstudiante();
            LlenarComboBoxAsignaturas();
            detalle = new List<InscripcionDetalle>();
        }

        public void LlenarComboBoxEstudiante()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            EstudiantecomboBox.DataSource = repositorio.GetList(x => true);
            EstudiantecomboBox.DisplayMember = "Estudiantes";

            EstudiantecomboBox.ValueMember = "EstudianteId";
        }

        public void LlenarMonto()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            AsignaturacomboBox.DataSource = repositorio.GetList(x => true);
            AsignaturacomboBox.DisplayMember = "Asignatura";

            AsignaturacomboBox.ValueMember = "Costo";
          //  MontonumericUpDown.Value = AsignaturacomboBox.SelectedIndex;
        }

        public void LlenarComboBoxAsignaturas()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            AsignaturacomboBox.DataSource = repositorio.GetList(x => true);
            AsignaturacomboBox.DisplayMember = "asignaturas";

            AsignaturacomboBox.ValueMember = "AsignaturaId";
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            EstudiantecomboBox.SelectedIndex = 0;
            AsignaturacomboBox.SelectedIndex = 0;
            FechadateTimePicker.Value = DateTime.Now;
            PrecionumericUpDown.Value = 0;
            MontonumericUpDown.Value = 0;
            detalle = new List<InscripcionDetalle>();
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.detalle;
        }

        private Inscripciones LlenaClase()
        {
            Inscripciones inscripcion = new Inscripciones();
            {
                inscripcion.InscripcionId = (int)IdnumericUpDown.Value;
                inscripcion.Fecha = FechadateTimePicker.Value;
                inscripcion.Precio = PrecionumericUpDown.Value;
                inscripcion.Monto = MontonumericUpDown.Value;
                inscripcion.Detalle = this.detalle;


            }
            return inscripcion;
        }

        private void LlenaCampo(Inscripciones inscripcion)
        {
            IdnumericUpDown.Value = inscripcion.InscripcionId;
            FechadateTimePicker.Value = inscripcion.Fecha;
            MontonumericUpDown.Value = inscripcion.Monto;
            PrecionumericUpDown.Value = inscripcion.Precio;
            DetalledataGridView.DataSource = inscripcion.Detalle;
            this.detalles = inscripcion.Detalle;
            CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Inscripciones>();
            Inscripciones inscripcion = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (inscripcion != null);
        }

        private bool Validar()
        {
            bool paso = true;
            if(PrecionumericUpDown.Value ==0)
            {
                ErrorProvider.SetError(PrecionumericUpDown, "Este campo no puede ser cero");
                paso = false;
            }

            if (MontonumericUpDown.Value == 0)
            {
                ErrorProvider.SetError(MontonumericUpDown, "Este Campo No puede Ser Cero");
                paso = false;
            }

            if(detalle.Count ==0)
            {
                ErrorProvider.SetError(DetalledataGridView, "El detalle no puede estar vacio...");
                paso = false;
            }
            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Inscripciones>();
            Inscripciones inscripcion;
            
            bool paso = false;

            if (!Validar())
                return;

            inscripcion = LlenaClase();
            if (IdnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(inscripcion);
            }
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Inscripcion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(inscripcion);
            }
            if (paso)
            {
                MessageBox.Show("Inscripcion Guardada!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            repositorio = new RepositorioBase<Inscripciones>();
            ErrorProvider.Clear();
            int.TryParse(IdnumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                ErrorProvider.SetError(IdnumericUpDown, "Inscripcion no existe!!!");
                return;
            }
            if(repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Inscripcion Eliminada!!", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Inscripciones>();
            Inscripciones inscripcion = new Inscripciones();

            int.TryParse(IdnumericUpDown.Text, out int id);

            inscripcion = repositorio.Buscar(id);

            if (inscripcion != null)
            {
                ErrorProvider.Clear();
                LlenaCampo(inscripcion);
            }
            else
                ErrorProvider.SetError(IdnumericUpDown, "Inscripcion  no encontrada");
        }

        private void addEstudiante_Click(object sender, EventArgs e)
        {
            rEstudiantes estudiante = new rEstudiantes();
            estudiante.Show();
        }

        private void addAsignatura_Click(object sender, EventArgs e)
        {
            rAsignatura asignatura = new rAsignatura();
            asignatura.ShowDialog();
        }

        private void detalleButton_Click(object sender, EventArgs e)
        {
            List<InscripcionDetalle> detalle = new List<InscripcionDetalle>();

            if (DetalledataGridView.DataSource != null)
            {
                detalle = (List<InscripcionDetalle>)DetalledataGridView.DataSource;
            }
            if (DetalledataGridView.DataSource != null)
              detalle = (List<InscripcionDetalle>)DetalledataGridView.DataSource;
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            this.detalle.Add(
          new InscripcionDetalle(
             //id: 0,
              inscripcionDetalleId: 0,
              inscripcionId: (int)IdnumericUpDown.Value,
              estudianteId: (int)EstudiantecomboBox.SelectedValue,
              monto: (int)MontonumericUpDown.Value
              ));
             CargarGrid();
        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
          RepositorioBase<Asignaturas>  repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();
           // Asignaturas asignatura = new Asignaturas();
            int id=1;

            asignatura = repositorio.Buscar(id);
            decimal credito =   asignatura.Creditos;
            decimal precio = PrecionumericUpDown.Value;

            MontonumericUpDown.Value = (asignatura.Creditos * precio);
            // PrecionumericUpDown.Value;
        }

        private void LLenarEstudiante(Estudiantes estudiante)
        {
            IdEstudiantenumericUpDown.Value = estudiante.EstudianteId;
            NombretextBox.Text = estudiante.Nombres;
        }

        private void MontonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();
            // Asignaturas asignatura = new Asignaturas();
            int id = Convert.ToInt32(AsignaturacomboBox.SelectedValue);
            
            asignatura = repositorio.Buscar(id);
            if (id == 0)
            {
                MessageBox.Show("No hay asignatura registrada");
                return;
            }
            else
                asignatura = repositorio.Buscar(id);
            decimal credito = asignatura.Creditos;
            decimal precio = PrecionumericUpDown.Value;
            MontonumericUpDown.Value = (asignatura.Creditos * precio);
        }

        private void BuscarEstbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            Estudiantes estudiante;

            int.TryParse(IdEstudiantenumericUpDown.Text, out int id);

            estudiante = repositorio.Buscar(id);

            if (estudiante != null)
            {
                ErrorProvider.Clear();
                LLenarEstudiante(estudiante);
            }
            else
                ErrorProvider.SetError(IdnumericUpDown, "Estudiante  no encontrado");
        }
    }
}

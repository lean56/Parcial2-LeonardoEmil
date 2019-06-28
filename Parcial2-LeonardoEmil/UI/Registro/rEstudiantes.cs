﻿using Parcial2_LeonardoEmil.Entidades;
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

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            BalancenumericUpDown.Value = 0;
            ErrorProvider.Clear();
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes()
            {
                EstudianteId = (int)(IdnumericUpDown.Value),
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

        private bool Validar()
        {
            bool paso = true;

            if (String.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                ErrorProvider.SetError(NombretextBox, "Este Campo No puede Estar Vacio!!");
                paso = false;
            }
         //   if (BalancenumericUpDown.Value == 0)
           // {
             //   ErrorProvider.SetError(BalancenumericUpDown, "Este Campo No puede Ser Cero");
               // paso = false;
            //}
            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Estudiantes>();

            Estudiantes estudiante;
            bool paso = false;

            if (!Validar())
                return;

            estudiante = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Estudiante que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }   
                paso = repositorio.Modificar(estudiante);
            }
            if(paso)
            {
                MessageBox.Show("Estudiante Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            repositorio = new RepositorioBase<Estudiantes>();
            ErrorProvider.Clear();
            int.TryParse(IdnumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                ErrorProvider.SetError(IdnumericUpDown, "Estudiante No Existe!!!");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Estudiante Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(IdnumericUpDown.Text, out int id);

            estudiante = repositorio.Buscar(id);

            if (estudiante != null)
            {
                ErrorProvider.Clear();
                LlenaCampo(estudiante);
            }
            else
                ErrorProvider.SetError(IdnumericUpDown, "Estudiante No Encontrado!!!");
        }
    }
}
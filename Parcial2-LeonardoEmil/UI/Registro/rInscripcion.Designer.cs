namespace Parcial2_LeonardoEmil.UI.Registro
{
    partial class rInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MontonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addEstudiante = new System.Windows.Forms.Label();
            this.addAsignatura = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.detalleButton = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IdEstudiantenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BuscarEstbutton = new System.Windows.Forms.Button();
            this.IdAsignumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarAsignbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudiantenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdAsignumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(80, 117);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.FechadateTimePicker.TabIndex = 1;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(79, 12);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.IdnumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estudiante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID_A";
            // 
            // MontonumericUpDown
            // 
            this.MontonumericUpDown.Location = new System.Drawing.Point(160, 322);
            this.MontonumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MontonumericUpDown.Name = "MontonumericUpDown";
            this.MontonumericUpDown.ReadOnly = true;
            this.MontonumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.MontonumericUpDown.TabIndex = 9;
            this.MontonumericUpDown.ValueChanged += new System.EventHandler(this.MontonumericUpDown_ValueChanged);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(168, 10);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 10;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(22, 348);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 11;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(112, 348);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(205, 348);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // addEstudiante
            // 
            this.addEstudiante.AutoSize = true;
            this.addEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEstudiante.Location = new System.Drawing.Point(267, 55);
            this.addEstudiante.Name = "addEstudiante";
            this.addEstudiante.Size = new System.Drawing.Size(18, 20);
            this.addEstudiante.TabIndex = 14;
            this.addEstudiante.Text = "+";
            this.addEstudiante.Click += new System.EventHandler(this.addEstudiante_Click);
            // 
            // addAsignatura
            // 
            this.addAsignatura.AutoSize = true;
            this.addAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAsignatura.Location = new System.Drawing.Point(156, 199);
            this.addAsignatura.Name = "addAsignatura";
            this.addAsignatura.Size = new System.Drawing.Size(18, 20);
            this.addAsignatura.TabIndex = 15;
            this.addAsignatura.Text = "+";
            this.addAsignatura.Click += new System.EventHandler(this.addAsignatura_Click);
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(23, 238);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(203, 70);
            this.DetalledataGridView.TabIndex = 16;
            // 
            // detalleButton
            // 
            this.detalleButton.AutoSize = true;
            this.detalleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleButton.Location = new System.Drawing.Point(309, 238);
            this.detalleButton.Name = "detalleButton";
            this.detalleButton.Size = new System.Drawing.Size(18, 20);
            this.detalleButton.TabIndex = 17;
            this.detalleButton.Text = "+";
            this.detalleButton.Click += new System.EventHandler(this.detalleButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio";
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(79, 158);
            this.PrecionumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.PrecionumericUpDown.TabIndex = 19;
            this.PrecionumericUpDown.ValueChanged += new System.EventHandler(this.PrecionumericUpDown_ValueChanged);
            // 
            // IdEstudiantenumericUpDown
            // 
            this.IdEstudiantenumericUpDown.Location = new System.Drawing.Point(79, 53);
            this.IdEstudiantenumericUpDown.Name = "IdEstudiantenumericUpDown";
            this.IdEstudiantenumericUpDown.Size = new System.Drawing.Size(102, 20);
            this.IdEstudiantenumericUpDown.TabIndex = 20;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(79, 82);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nombre";
            // 
            // BuscarEstbutton
            // 
            this.BuscarEstbutton.Location = new System.Drawing.Point(187, 53);
            this.BuscarEstbutton.Name = "BuscarEstbutton";
            this.BuscarEstbutton.Size = new System.Drawing.Size(63, 23);
            this.BuscarEstbutton.TabIndex = 23;
            this.BuscarEstbutton.Text = "Buscar";
            this.BuscarEstbutton.UseVisualStyleBackColor = true;
            this.BuscarEstbutton.Click += new System.EventHandler(this.BuscarEstbutton_Click);
            // 
            // IdAsignumericUpDown
            // 
            this.IdAsignumericUpDown.Location = new System.Drawing.Point(41, 200);
            this.IdAsignumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.IdAsignumericUpDown.Name = "IdAsignumericUpDown";
            this.IdAsignumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.IdAsignumericUpDown.TabIndex = 24;
            // 
            // BuscarAsignbutton
            // 
            this.BuscarAsignbutton.Location = new System.Drawing.Point(111, 197);
            this.BuscarAsignbutton.Name = "BuscarAsignbutton";
            this.BuscarAsignbutton.Size = new System.Drawing.Size(43, 23);
            this.BuscarAsignbutton.TabIndex = 25;
            this.BuscarAsignbutton.Text = "Buscar";
            this.BuscarAsignbutton.UseVisualStyleBackColor = true;
            this.BuscarAsignbutton.Click += new System.EventHandler(this.BuscarAsignbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Descripcion";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(246, 199);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripciontextBox.TabIndex = 26;
            // 
            // rInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 439);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.BuscarAsignbutton);
            this.Controls.Add(this.IdAsignumericUpDown);
            this.Controls.Add(this.BuscarEstbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IdEstudiantenumericUpDown);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.detalleButton);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.addAsignatura);
            this.Controls.Add(this.addEstudiante);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.MontonumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "rInscripcion";
            this.Text = "rInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudiantenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdAsignumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label addAsignatura;
        private System.Windows.Forms.Label addEstudiante;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Label detalleButton;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown MontonumericUpDown;
        private System.Windows.Forms.Button BuscarEstbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.NumericUpDown IdEstudiantenumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Button BuscarAsignbutton;
        private System.Windows.Forms.NumericUpDown IdAsignumericUpDown;
    }
}
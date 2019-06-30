namespace Parcial2_LeonardoEmil
{
    partial class Principal
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
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.Max = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.HideButton = new System.Windows.Forms.PictureBox();
            this.RegistroAsignatura = new System.Windows.Forms.Button();
            this.RegistroInscripcion = new System.Windows.Forms.Button();
            this.RegistroEstudiante = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuVertical.Controls.Add(this.RegistroAsignatura);
            this.MenuVertical.Controls.Add(this.RegistroInscripcion);
            this.MenuVertical.Controls.Add(this.RegistroEstudiante);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(176, 580);
            this.MenuVertical.TabIndex = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.BarraTitulo.Controls.Add(this.restaurar);
            this.BarraTitulo.Controls.Add(this.min);
            this.BarraTitulo.Controls.Add(this.Max);
            this.BarraTitulo.Controls.Add(this.Salir);
            this.BarraTitulo.Controls.Add(this.HideButton);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(176, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(794, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(176, 50);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(794, 530);
            this.PanelContenedor.TabIndex = 2;
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.Image = global::Parcial2_LeonardoEmil.Properties.Resources.icon_restaurar;
            this.restaurar.Location = new System.Drawing.Point(722, 9);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(30, 30);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar.TabIndex = 7;
            this.restaurar.TabStop = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.Image = global::Parcial2_LeonardoEmil.Properties.Resources.icon_minimizar1;
            this.min.Location = new System.Drawing.Point(686, 9);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(30, 30);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min.TabIndex = 6;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.Image = global::Parcial2_LeonardoEmil.Properties.Resources.icon_maximizar;
            this.Max.Location = new System.Drawing.Point(722, 9);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(30, 30);
            this.Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Max.TabIndex = 4;
            this.Max.TabStop = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = global::Parcial2_LeonardoEmil.Properties.Resources.icon_cerrar2;
            this.Salir.Location = new System.Drawing.Point(758, 9);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 5;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // HideButton
            // 
            this.HideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.HideButton.Image = global::Parcial2_LeonardoEmil.Properties.Resources.ic_menu_128_28650;
            this.HideButton.Location = new System.Drawing.Point(6, 9);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(35, 35);
            this.HideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HideButton.TabIndex = 0;
            this.HideButton.TabStop = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // RegistroAsignatura
            // 
            this.RegistroAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.RegistroAsignatura.FlatAppearance.BorderSize = 0;
            this.RegistroAsignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RegistroAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistroAsignatura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistroAsignatura.Image = global::Parcial2_LeonardoEmil.Properties.Resources.folder_my_documents_15435;
            this.RegistroAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistroAsignatura.Location = new System.Drawing.Point(6, 114);
            this.RegistroAsignatura.Name = "RegistroAsignatura";
            this.RegistroAsignatura.Size = new System.Drawing.Size(164, 47);
            this.RegistroAsignatura.TabIndex = 7;
            this.RegistroAsignatura.Text = "Registro Asignatura";
            this.RegistroAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistroAsignatura.UseVisualStyleBackColor = false;
            this.RegistroAsignatura.Click += new System.EventHandler(this.RegistroAsignatura_Click_1);
            // 
            // RegistroInscripcion
            // 
            this.RegistroInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.RegistroInscripcion.FlatAppearance.BorderSize = 0;
            this.RegistroInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RegistroInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistroInscripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistroInscripcion.Image = global::Parcial2_LeonardoEmil.Properties.Resources.travel_journey_icon_icons_com_55995;
            this.RegistroInscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistroInscripcion.Location = new System.Drawing.Point(3, 258);
            this.RegistroInscripcion.Name = "RegistroInscripcion";
            this.RegistroInscripcion.Size = new System.Drawing.Size(164, 47);
            this.RegistroInscripcion.TabIndex = 6;
            this.RegistroInscripcion.Text = "Registro Inscripcion";
            this.RegistroInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistroInscripcion.UseVisualStyleBackColor = false;
            this.RegistroInscripcion.Click += new System.EventHandler(this.RegistroInscripcion_Click);
            // 
            // RegistroEstudiante
            // 
            this.RegistroEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.RegistroEstudiante.FlatAppearance.BorderSize = 0;
            this.RegistroEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RegistroEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistroEstudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistroEstudiante.Image = global::Parcial2_LeonardoEmil.Properties.Resources.Student_id_35758;
            this.RegistroEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistroEstudiante.Location = new System.Drawing.Point(3, 182);
            this.RegistroEstudiante.Name = "RegistroEstudiante";
            this.RegistroEstudiante.Size = new System.Drawing.Size(164, 48);
            this.RegistroEstudiante.TabIndex = 5;
            this.RegistroEstudiante.Text = "Registro Estudiante";
            this.RegistroEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistroEstudiante.UseVisualStyleBackColor = false;
            this.RegistroEstudiante.Click += new System.EventHandler(this.RegistroEstudiante_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(970, 580);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox HideButton;
        private System.Windows.Forms.PictureBox Max;
        private System.Windows.Forms.Button RegistroEstudiante;
        private System.Windows.Forms.Button RegistroInscripcion;
        private System.Windows.Forms.Button RegistroAsignatura;
        public System.Windows.Forms.Panel PanelContenedor;
    }
}
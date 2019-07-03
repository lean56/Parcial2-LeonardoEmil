namespace Parcial2_LeonardoEmil.UI.Reportes
{
    partial class rptInscripcion
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
            this.InscripcioncrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // InscripcioncrystalReportViewer
            // 
            this.InscripcioncrystalReportViewer.ActiveViewIndex = -1;
            this.InscripcioncrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InscripcioncrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.InscripcioncrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InscripcioncrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.InscripcioncrystalReportViewer.Name = "InscripcioncrystalReportViewer";
            this.InscripcioncrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.InscripcioncrystalReportViewer.TabIndex = 0;
            this.InscripcioncrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // rptInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InscripcioncrystalReportViewer);
            this.Name = "rptInscripcion";
            this.Text = "rptInscripcion";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer InscripcioncrystalReportViewer;
    }
}
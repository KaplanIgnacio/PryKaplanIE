namespace PryKaplanTrabajo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LblCargando = new System.Windows.Forms.Label();
            this.PctImagenCarga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctImagenCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(37, 256);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(514, 32);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // LblCargando
            // 
            this.LblCargando.AutoSize = true;
            this.LblCargando.Location = new System.Drawing.Point(259, 303);
            this.LblCargando.Name = "LblCargando";
            this.LblCargando.Size = new System.Drawing.Size(62, 13);
            this.LblCargando.TabIndex = 2;
            this.LblCargando.Text = "Cargando...";
            // 
            // PctImagenCarga
            // 
            this.PctImagenCarga.Image = global::PryKaplanTrabajo.Properties.Resources.seguroooo;
            this.PctImagenCarga.Location = new System.Drawing.Point(36, 60);
            this.PctImagenCarga.Name = "PctImagenCarga";
            this.PctImagenCarga.Size = new System.Drawing.Size(515, 168);
            this.PctImagenCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctImagenCarga.TabIndex = 0;
            this.PctImagenCarga.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(600, 339);
            this.Controls.Add(this.LblCargando);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PctImagenCarga);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.PctImagenCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctImagenCarga;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LblCargando;
    }
}


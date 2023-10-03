namespace PryKaplanTrabajo
{
    partial class FrmGrilla
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
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juridisccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liquidador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnVerGrilla = new System.Windows.Forms.Button();
            this.BtnSalir3 = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProveedores
            // 
            this.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Entidad,
            this.Apertura,
            this.Expediente,
            this.Juzgado,
            this.Juridisccion,
            this.Liquidador});
            this.DgvProveedores.Location = new System.Drawing.Point(28, 24);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.Size = new System.Drawing.Size(743, 289);
            this.DgvProveedores.TabIndex = 0;
            this.DgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellClick);
            this.DgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "N°";
            this.Nombre.Name = "Nombre";
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            // 
            // Apertura
            // 
            this.Apertura.HeaderText = "Apertura";
            this.Apertura.Name = "Apertura";
            // 
            // Expediente
            // 
            this.Expediente.HeaderText = "N° Expediente";
            this.Expediente.Name = "Expediente";
            // 
            // Juzgado
            // 
            this.Juzgado.HeaderText = "Juzgado";
            this.Juzgado.Name = "Juzgado";
            // 
            // Juridisccion
            // 
            this.Juridisccion.HeaderText = "Jurisd";
            this.Juridisccion.Name = "Juridisccion";
            // 
            // Liquidador
            // 
            this.Liquidador.HeaderText = "Liquidador";
            this.Liquidador.Name = "Liquidador";
            // 
            // BtnVerGrilla
            // 
            this.BtnVerGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerGrilla.Location = new System.Drawing.Point(63, 354);
            this.BtnVerGrilla.Name = "BtnVerGrilla";
            this.BtnVerGrilla.Size = new System.Drawing.Size(109, 59);
            this.BtnVerGrilla.TabIndex = 1;
            this.BtnVerGrilla.Text = "Ver Grilla";
            this.BtnVerGrilla.UseVisualStyleBackColor = true;
            this.BtnVerGrilla.Click += new System.EventHandler(this.BtnVerGrilla_Click);
            // 
            // BtnSalir3
            // 
            this.BtnSalir3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir3.Location = new System.Drawing.Point(718, 357);
            this.BtnSalir3.Name = "BtnSalir3";
            this.BtnSalir3.Size = new System.Drawing.Size(69, 54);
            this.BtnSalir3.TabIndex = 2;
            this.BtnSalir3.Text = "Salir";
            this.BtnSalir3.UseVisualStyleBackColor = true;
            this.BtnSalir3.Click += new System.EventHandler(this.BtnSalir3_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(263, 357);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(90, 54);
            this.BtnCargar.TabIndex = 3;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(430, 357);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(89, 56);
            this.BtnBorrar.TabIndex = 4;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // FrmGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnSalir3);
            this.Controls.Add(this.BtnVerGrilla);
            this.Controls.Add(this.DgvProveedores);
            this.Name = "FrmGrilla";
            this.Text = "FrmGrilla";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juridisccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liquidador;
        private System.Windows.Forms.Button BtnVerGrilla;
        private System.Windows.Forms.Button BtnSalir3;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnBorrar;
    }
}
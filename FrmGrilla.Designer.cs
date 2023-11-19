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
            this.BtnVolverMenu = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProveedores
            // 
            this.DgvProveedores.AllowUserToAddRows = false;
            this.DgvProveedores.AllowUserToDeleteRows = false;
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
            this.DgvProveedores.ReadOnly = true;
            this.DgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProveedores.Size = new System.Drawing.Size(743, 289);
            this.DgvProveedores.TabIndex = 0;
            this.DgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellClick);
            this.DgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "N°";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            this.Entidad.ReadOnly = true;
            // 
            // Apertura
            // 
            this.Apertura.HeaderText = "Apertura";
            this.Apertura.Name = "Apertura";
            this.Apertura.ReadOnly = true;
            // 
            // Expediente
            // 
            this.Expediente.HeaderText = "N° Expediente";
            this.Expediente.Name = "Expediente";
            this.Expediente.ReadOnly = true;
            // 
            // Juzgado
            // 
            this.Juzgado.HeaderText = "Juzgado";
            this.Juzgado.Name = "Juzgado";
            this.Juzgado.ReadOnly = true;
            // 
            // Juridisccion
            // 
            this.Juridisccion.HeaderText = "Jurisd";
            this.Juridisccion.Name = "Juridisccion";
            this.Juridisccion.ReadOnly = true;
            // 
            // Liquidador
            // 
            this.Liquidador.HeaderText = "Liquidador";
            this.Liquidador.Name = "Liquidador";
            this.Liquidador.ReadOnly = true;
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
            // BtnVolverMenu
            // 
            this.BtnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverMenu.Location = new System.Drawing.Point(610, 356);
            this.BtnVolverMenu.Name = "BtnVolverMenu";
            this.BtnVolverMenu.Size = new System.Drawing.Size(113, 59);
            this.BtnVolverMenu.TabIndex = 2;
            this.BtnVolverMenu.Text = "Volver al Menú";
            this.BtnVolverMenu.UseVisualStyleBackColor = true;
            this.BtnVolverMenu.Click += new System.EventHandler(this.BtnSalir3_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(257, 354);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(109, 61);
            this.BtnCargar.TabIndex = 3;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(426, 354);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(109, 61);
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
            this.Controls.Add(this.BtnVolverMenu);
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
        private System.Windows.Forms.Button BtnVolverMenu;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnBorrar;
    }
}
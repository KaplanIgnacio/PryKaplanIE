namespace PryKaplanTrabajo
{
    partial class FrmClientes
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
            this.dgvDatosClientes = new System.Windows.Forms.DataGridView();
            this.BarraInferior = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCambiarEstadoCliente = new System.Windows.Forms.Button();
            this.lblCambiarEstadoCliente = new System.Windows.Forms.Label();
            this.txtCambiarEstadoCliente = new System.Windows.Forms.TextBox();
            this.btnBusquedaCliente = new System.Windows.Forms.Button();
            this.lblBusquedaCliente = new System.Windows.Forms.Label();
            this.txtBusquedaCliente = new System.Windows.Forms.TextBox();
            this.btnVolverMenu2 = new System.Windows.Forms.Button();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.lblBuscarID = new System.Windows.Forms.Label();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.lblInstruccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).BeginInit();
            this.BarraInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosClientes
            // 
            this.dgvDatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosClientes.Location = new System.Drawing.Point(83, 12);
            this.dgvDatosClientes.Name = "dgvDatosClientes";
            this.dgvDatosClientes.Size = new System.Drawing.Size(741, 274);
            this.dgvDatosClientes.TabIndex = 0;
            this.dgvDatosClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosClientes_CellClick);
            this.dgvDatosClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatosClientes_CellMouseClick);
            // 
            // BarraInferior
            // 
            this.BarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion});
            this.BarraInferior.Location = new System.Drawing.Point(0, 468);
            this.BarraInferior.Name = "BarraInferior";
            this.BarraInferior.Size = new System.Drawing.Size(909, 22);
            this.BarraInferior.TabIndex = 1;
            this.BarraInferior.Text = "statusStrip1";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(12, 17);
            this.lblEstadoConexion.Text = "-";
            // 
            // btnCambiarEstadoCliente
            // 
            this.btnCambiarEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstadoCliente.Location = new System.Drawing.Point(722, 359);
            this.btnCambiarEstadoCliente.Name = "btnCambiarEstadoCliente";
            this.btnCambiarEstadoCliente.Size = new System.Drawing.Size(172, 53);
            this.btnCambiarEstadoCliente.TabIndex = 2;
            this.btnCambiarEstadoCliente.Text = "Cambiar Estado del Cliente";
            this.btnCambiarEstadoCliente.UseVisualStyleBackColor = true;
            this.btnCambiarEstadoCliente.Click += new System.EventHandler(this.btnCambiarEstadoCliente_Click);
            // 
            // lblCambiarEstadoCliente
            // 
            this.lblCambiarEstadoCliente.AutoSize = true;
            this.lblCambiarEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarEstadoCliente.Location = new System.Drawing.Point(650, 335);
            this.lblCambiarEstadoCliente.Name = "lblCambiarEstadoCliente";
            this.lblCambiarEstadoCliente.Size = new System.Drawing.Size(127, 20);
            this.lblCambiarEstadoCliente.TabIndex = 3;
            this.lblCambiarEstadoCliente.Text = "Cambiar Estado:";
            // 
            // txtCambiarEstadoCliente
            // 
            this.txtCambiarEstadoCliente.Location = new System.Drawing.Point(773, 335);
            this.txtCambiarEstadoCliente.Name = "txtCambiarEstadoCliente";
            this.txtCambiarEstadoCliente.Size = new System.Drawing.Size(124, 20);
            this.txtCambiarEstadoCliente.TabIndex = 4;
            // 
            // btnBusquedaCliente
            // 
            this.btnBusquedaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaCliente.Location = new System.Drawing.Point(114, 359);
            this.btnBusquedaCliente.Name = "btnBusquedaCliente";
            this.btnBusquedaCliente.Size = new System.Drawing.Size(171, 53);
            this.btnBusquedaCliente.TabIndex = 5;
            this.btnBusquedaCliente.Text = "Buscar";
            this.btnBusquedaCliente.UseVisualStyleBackColor = true;
            this.btnBusquedaCliente.Click += new System.EventHandler(this.btnBusquedaCliente_Click);
            // 
            // lblBusquedaCliente
            // 
            this.lblBusquedaCliente.AutoSize = true;
            this.lblBusquedaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaCliente.Location = new System.Drawing.Point(12, 331);
            this.lblBusquedaCliente.Name = "lblBusquedaCliente";
            this.lblBusquedaCliente.Size = new System.Drawing.Size(204, 20);
            this.lblBusquedaCliente.TabIndex = 6;
            this.lblBusquedaCliente.Text = "Buscar cliente por Apellido: ";
            // 
            // txtBusquedaCliente
            // 
            this.txtBusquedaCliente.Location = new System.Drawing.Point(210, 333);
            this.txtBusquedaCliente.Name = "txtBusquedaCliente";
            this.txtBusquedaCliente.Size = new System.Drawing.Size(124, 20);
            this.txtBusquedaCliente.TabIndex = 7;
            // 
            // btnVolverMenu2
            // 
            this.btnVolverMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu2.Location = new System.Drawing.Point(766, 429);
            this.btnVolverMenu2.Name = "btnVolverMenu2";
            this.btnVolverMenu2.Size = new System.Drawing.Size(128, 36);
            this.btnVolverMenu2.TabIndex = 8;
            this.btnVolverMenu2.Text = "Volver al Menú";
            this.btnVolverMenu2.UseVisualStyleBackColor = true;
            this.btnVolverMenu2.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(520, 337);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(124, 20);
            this.txtBuscarID.TabIndex = 11;
            // 
            // lblBuscarID
            // 
            this.lblBuscarID.AutoSize = true;
            this.lblBuscarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarID.Location = new System.Drawing.Point(363, 335);
            this.lblBuscarID.Name = "lblBuscarID";
            this.lblBuscarID.Size = new System.Drawing.Size(165, 20);
            this.lblBuscarID.TabIndex = 10;
            this.lblBuscarID.Text = "Buscar cliente por ID: ";
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarID.Location = new System.Drawing.Point(438, 361);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(171, 53);
            this.btnBuscarID.TabIndex = 9;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(677, 319);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(208, 13);
            this.lblInstruccion.TabIndex = 12;
            this.lblInstruccion.Text = "(Presionar el registro del Estado en la grilla)";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 490);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.txtBuscarID);
            this.Controls.Add(this.lblBuscarID);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.btnVolverMenu2);
            this.Controls.Add(this.txtBusquedaCliente);
            this.Controls.Add(this.lblBusquedaCliente);
            this.Controls.Add(this.btnBusquedaCliente);
            this.Controls.Add(this.txtCambiarEstadoCliente);
            this.Controls.Add(this.lblCambiarEstadoCliente);
            this.Controls.Add(this.btnCambiarEstadoCliente);
            this.Controls.Add(this.BarraInferior);
            this.Controls.Add(this.dgvDatosClientes);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).EndInit();
            this.BarraInferior.ResumeLayout(false);
            this.BarraInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosClientes;
        private System.Windows.Forms.StatusStrip BarraInferior;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.Button btnCambiarEstadoCliente;
        private System.Windows.Forms.Label lblCambiarEstadoCliente;
        private System.Windows.Forms.TextBox txtCambiarEstadoCliente;
        private System.Windows.Forms.Button btnBusquedaCliente;
        private System.Windows.Forms.Label lblBusquedaCliente;
        private System.Windows.Forms.TextBox txtBusquedaCliente;
        private System.Windows.Forms.Button btnVolverMenu2;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.Label lblBuscarID;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Label lblInstruccion;
    }
}
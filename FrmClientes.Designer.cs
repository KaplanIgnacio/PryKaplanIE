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
            this.btnSalir3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).BeginInit();
            this.BarraInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosClientes
            // 
            this.dgvDatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosClientes.Location = new System.Drawing.Point(29, 16);
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
            this.BarraInferior.Location = new System.Drawing.Point(0, 428);
            this.BarraInferior.Name = "BarraInferior";
            this.BarraInferior.Size = new System.Drawing.Size(800, 22);
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
            this.btnCambiarEstadoCliente.Location = new System.Drawing.Point(438, 359);
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
            this.lblCambiarEstadoCliente.Location = new System.Drawing.Point(380, 333);
            this.lblCambiarEstadoCliente.Name = "lblCambiarEstadoCliente";
            this.lblCambiarEstadoCliente.Size = new System.Drawing.Size(88, 20);
            this.lblCambiarEstadoCliente.TabIndex = 3;
            this.lblCambiarEstadoCliente.Text = "Ingrese ID:";
            // 
            // txtCambiarEstadoCliente
            // 
            this.txtCambiarEstadoCliente.Location = new System.Drawing.Point(486, 333);
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
            this.lblBusquedaCliente.Size = new System.Drawing.Size(165, 20);
            this.lblBusquedaCliente.TabIndex = 6;
            this.lblBusquedaCliente.Text = "Buscar cliente por ID: ";
            // 
            // txtBusquedaCliente
            // 
            this.txtBusquedaCliente.Location = new System.Drawing.Point(183, 331);
            this.txtBusquedaCliente.Name = "txtBusquedaCliente";
            this.txtBusquedaCliente.Size = new System.Drawing.Size(124, 20);
            this.txtBusquedaCliente.TabIndex = 7;
            // 
            // btnSalir3
            // 
            this.btnSalir3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir3.Location = new System.Drawing.Point(670, 359);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(81, 52);
            this.btnSalir3.TabIndex = 8;
            this.btnSalir3.Text = "Salir";
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir3);
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
        private System.Windows.Forms.Button btnSalir3;
    }
}
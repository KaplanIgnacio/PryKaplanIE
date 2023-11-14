namespace PryKaplanTrabajo
{
    partial class FrmRegistrarUsuario
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
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.LblRegistrarClave = new System.Windows.Forms.Label();
            this.LblRegistrarUsuario = new System.Windows.Forms.Label();
            this.TxtRegistrarClave = new System.Windows.Forms.TextBox();
            this.TxtRegistrarUsuario = new System.Windows.Forms.TextBox();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(114, 220);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(132, 47);
            this.btnRegistrarUsuario.TabIndex = 0;
            this.btnRegistrarUsuario.Text = "Registrarse";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // LblRegistrarClave
            // 
            this.LblRegistrarClave.AutoSize = true;
            this.LblRegistrarClave.BackColor = System.Drawing.Color.Transparent;
            this.LblRegistrarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrarClave.Location = new System.Drawing.Point(111, 152);
            this.LblRegistrarClave.Name = "LblRegistrarClave";
            this.LblRegistrarClave.Size = new System.Drawing.Size(42, 16);
            this.LblRegistrarClave.TabIndex = 8;
            this.LblRegistrarClave.Text = "Clave";
            // 
            // LblRegistrarUsuario
            // 
            this.LblRegistrarUsuario.AutoSize = true;
            this.LblRegistrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrarUsuario.Location = new System.Drawing.Point(111, 95);
            this.LblRegistrarUsuario.Name = "LblRegistrarUsuario";
            this.LblRegistrarUsuario.Size = new System.Drawing.Size(103, 16);
            this.LblRegistrarUsuario.TabIndex = 7;
            this.LblRegistrarUsuario.Text = "Nombre usuario";
            // 
            // TxtRegistrarClave
            // 
            this.TxtRegistrarClave.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtRegistrarClave.Location = new System.Drawing.Point(114, 171);
            this.TxtRegistrarClave.Name = "TxtRegistrarClave";
            this.TxtRegistrarClave.Size = new System.Drawing.Size(132, 20);
            this.TxtRegistrarClave.TabIndex = 6;
            // 
            // TxtRegistrarUsuario
            // 
            this.TxtRegistrarUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtRegistrarUsuario.Location = new System.Drawing.Point(114, 114);
            this.TxtRegistrarUsuario.Name = "TxtRegistrarUsuario";
            this.TxtRegistrarUsuario.Size = new System.Drawing.Size(132, 20);
            this.TxtRegistrarUsuario.TabIndex = 5;
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoUsuario.Location = new System.Drawing.Point(54, 28);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(305, 53);
            this.lblNuevoUsuario.TabIndex = 9;
            this.lblNuevoUsuario.Text = "Por favor, escribe un nombre y una contraseña para completar el registro de usuar" +
    "io.";
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(380, 294);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Controls.Add(this.LblRegistrarClave);
            this.Controls.Add(this.LblRegistrarUsuario);
            this.Controls.Add(this.TxtRegistrarClave);
            this.Controls.Add(this.TxtRegistrarUsuario);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Name = "FrmRegistrarUsuario";
            this.Text = "FrmRegistrarUsuario";
            this.Load += new System.EventHandler(this.FrmRegistrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Label LblRegistrarClave;
        private System.Windows.Forms.Label LblRegistrarUsuario;
        private System.Windows.Forms.TextBox TxtRegistrarClave;
        private System.Windows.Forms.TextBox TxtRegistrarUsuario;
        private System.Windows.Forms.Label lblNuevoUsuario;
    }
}
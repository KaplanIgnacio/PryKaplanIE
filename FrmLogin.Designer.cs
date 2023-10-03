namespace PryKaplanTrabajo
{
    partial class FrmLogin
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
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            this.Lblngresar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtUsuario.Location = new System.Drawing.Point(139, 107);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(132, 20);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtClave.Location = new System.Drawing.Point(139, 175);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(132, 20);
            this.TxtClave.TabIndex = 1;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnIngresar.Location = new System.Drawing.Point(139, 229);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(132, 42);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Silver;
            this.LblUsuario.Location = new System.Drawing.Point(136, 91);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(81, 13);
            this.LblUsuario.TabIndex = 3;
            this.LblUsuario.Text = "Nombre usuario";
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.BackColor = System.Drawing.Color.Silver;
            this.LblClave.Location = new System.Drawing.Point(136, 159);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(34, 13);
            this.LblClave.TabIndex = 4;
            this.LblClave.Text = "Clave";
            // 
            // Lblngresar
            // 
            this.Lblngresar.AutoSize = true;
            this.Lblngresar.BackColor = System.Drawing.Color.Silver;
            this.Lblngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblngresar.Location = new System.Drawing.Point(135, 30);
            this.Lblngresar.Name = "Lblngresar";
            this.Lblngresar.Size = new System.Drawing.Size(122, 24);
            this.Lblngresar.TabIndex = 5;
            this.Lblngresar.Text = "Iniciar Sesión";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PryKaplanTrabajo.Properties.Resources.fondo_login;
            this.ClientSize = new System.Drawing.Size(417, 310);
            this.Controls.Add(this.Lblngresar);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUsuario);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Label Lblngresar;
    }
}
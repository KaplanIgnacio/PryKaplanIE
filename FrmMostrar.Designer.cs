namespace PryKaplanTrabajo
{
    partial class FrmMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrar));
            this.trvMostrar = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listMostrar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // trvMostrar
            // 
            this.trvMostrar.ImageIndex = 0;
            this.trvMostrar.ImageList = this.imageList1;
            this.trvMostrar.Location = new System.Drawing.Point(56, 15);
            this.trvMostrar.Name = "trvMostrar";
            this.trvMostrar.SelectedImageIndex = 0;
            this.trvMostrar.Size = new System.Drawing.Size(267, 180);
            this.trvMostrar.TabIndex = 0;
            this.trvMostrar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMostrar_AfterSelect);
            this.trvMostrar.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMostrar_NodeMouseClick);
            this.trvMostrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trvMostrar_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carpetita.png");
            // 
            // listMostrar
            // 
            this.listMostrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listMostrar.HideSelection = false;
            this.listMostrar.Location = new System.Drawing.Point(400, 18);
            this.listMostrar.Name = "listMostrar";
            this.listMostrar.Size = new System.Drawing.Size(257, 177);
            this.listMostrar.TabIndex = 1;
            this.listMostrar.UseCompatibleStateImageBehavior = false;
            this.listMostrar.View = System.Windows.Forms.View.Details;
            this.listMostrar.DoubleClick += new System.EventHandler(this.listMostrar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Última Modificación";
            this.columnHeader3.Width = 114;
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 221);
            this.Controls.Add(this.listMostrar);
            this.Controls.Add(this.trvMostrar);
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvMostrar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listMostrar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}